using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TicketTVD.Services.EventAPI.Data;
using TicketTVD.Services.EventAPI.Models;
using TicketTVD.Services.EventAPI.Models.Dto;
using TicketTVD.Services.EventAPI.Models.Enum;
using TicketTVD.Services.EventAPI.Services.IServices;

namespace TicketTVD.Services.EventAPI.Services;

public class EventService : IEventService
{
    private readonly ApplicationDbContext _db;
    private readonly IMapper _mapper;
    private readonly ITicketService _ticketService;
    private readonly IAlbumService _albumService;

    public EventService(ApplicationDbContext db, IMapper mapper, ITicketService ticketService,
        IAlbumService albumService)
    {
        _db = db;
        _mapper = mapper;
        _ticketService = ticketService;
        _albumService = albumService;
    }

    public async Task<IEnumerable<EventDto>> GetEvents(string? search)
    {
        try
        {
            var events = new List<Event>();
            if (search != null && search != "")
            {
                events = _db.Events.Where(e => e.Name.ToLower().Contains(search.ToLower())).ToList();
            }
            else
            {
                events = _db.Events.ToList();
            }

            var eventDtos = _mapper.Map<IEnumerable<EventDto>>(events);

            foreach (var eventDto in eventDtos)
            {
                var ticketDetailDto = await _ticketService.GetTicketDetailByEventId(eventDto.Id);
                eventDto.TicketPrice = ticketDetailDto.Price;
                eventDto.TicketQuantity = ticketDetailDto.Quantity;
                eventDto.TicketSoldQuantity = 0;
            }


            return eventDtos;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<IEnumerable<EventStatistic>> GetEventsStatisticByCategory()
    {
        try
        {
            var statistic = await _db.Events
                .GroupBy(e => e.CategoryId)
                .Select(pl => new EventStatistic()
                {
                    CategoryId = pl.Key,
                    EventQuantity = pl.Count(),
                }).ToListAsync();

            return statistic;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<IEnumerable<EventDto>> GetEventsByTickets(EventsByTicketsDto eventsByTicketsDto)
    {
        try
        {
            var events = new List<Event>();
            if (eventsByTicketsDto.Search != null && eventsByTicketsDto.Search != "")
            {
                // events = _db.Events .Where(e => e.Name.ToLower().Contains(eventsByTicketsDto.Search.ToLower())).ToList();
                events = (from e in _db.Events
                    join id in eventsByTicketsDto.EventIds on e.Id equals id
                    where e.Name.ToLower().Contains(eventsByTicketsDto.Search.ToLower())
                    select e).ToList();
            }
            else
            {
                events = (from e in _db.Events
                    join id in eventsByTicketsDto.EventIds on e.Id equals id
                    select e).ToList();
            }

            var eventDtos = _mapper.Map<IEnumerable<EventDto>>(events);

            foreach (var eventDto in eventDtos)
            {
                var ticketDetailDto = await _ticketService.GetTicketDetailByEventId(eventDto.Id);
                eventDto.TicketPrice = ticketDetailDto.Price;
                eventDto.TicketQuantity = ticketDetailDto.Quantity;
                eventDto.TicketSoldQuantity = 0;
            }


            return eventDtos;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<IEnumerable<EventDto>> GetEventsByOrganizerId(string organizerId)
    {
        try
        {
            var events = _db.Events.Where(e => e.CreatorId == organizerId).ToList();
            var eventDtos = _mapper.Map<IEnumerable<EventDto>>(events);

            foreach (var eventDto in eventDtos)
            {
                var ticketDetailDto = await _ticketService.GetTicketDetailByEventId(eventDto.Id);
                eventDto.TicketPrice = ticketDetailDto.Price;
                eventDto.TicketQuantity = ticketDetailDto.Quantity;
                eventDto.TicketSoldQuantity = 0;
            }


            return eventDtos;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<DetailEventDto?> GetEventById(int eventId)
    {
        try
        {
            var eventFromDb = _db.Events.FirstOrDefault(u => u.Id == eventId);

            if (eventFromDb is null)
            {
                return null;
            }

            var eventDto = _mapper.Map<DetailEventDto>(eventFromDb);

            if (eventFromDb.PublishTime == null)
            {
                eventDto.PublishTime = null;
            }

            var ticketDetailDto = await _ticketService.GetTicketDetailByEventId(eventDto.Id);
            var albums = await _albumService.GetAlbumsByEventId(eventDto.Id);

            eventDto.TicketPrice = ticketDetailDto.Price;
            eventDto.TicketIsPaid = ticketDetailDto.IsPaid;
            eventDto.TicketQuantity = ticketDetailDto.Quantity;
            eventDto.TicketStartTime = ticketDetailDto.StartTime;
            eventDto.TicketCloseTime = ticketDetailDto.CloseTime;
            eventDto.Album = albums.Select(a => a.Uri);

            return eventDto;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<bool> CreateEvent(CreateEventDto createEventDto)
    {
        try
        {
            var newEvent = _mapper.Map<Event>(createEventDto);

            if (newEvent.EventDate > DateTime.Now)
            {
                newEvent.Status = Status.UPCOMING;
            }
            else if (newEvent.EventDate.Year == DateTime.Now.Year && newEvent.EventDate.Month == DateTime.Now.Month &&
                     newEvent.EventDate.Day == DateTime.Now.Month)
            {
                newEvent.Status = Status.OPENING;
            }
            else
            {
                newEvent.Status = Status.CLOSED;
            }

            if (createEventDto.PublishTime != null)
            {
                newEvent.PublishTime = createEventDto.PublishTime;
            }

            newEvent.Favourite = 0;
            newEvent.Share = 0;

            newEvent.CreatedAt = DateTime.Now;
            newEvent.UpdatedAt = DateTime.Now;

            var createdEvent = await _db.Events.AddAsync(newEvent);


            await _db.SaveChangesAsync();

            await _ticketService.CreateTicketDetail(new CreateTicketDetailDto
            {
                EventId = createdEvent.Entity.Id,
                IsPaid = createEventDto.TicketIsPaid,
                Price = createEventDto.TicketPrice ?? 0,
                Quantity = createEventDto.TicketQuantity,
                StartTime = createEventDto.TicketStartTime,
                CloseTime = createEventDto.TicketCloseTime,
            });

            await _albumService.AddImagesToAlbum(createdEvent.Entity.Id, createEventDto.Album);

            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<bool> UpdateEvent(int eventId, UpdateEventDto updateEventDto)
    {
        try
        {
            var eventFromDb = _db.Events.FirstOrDefault(u => u.Id == eventId);

            if (eventFromDb is null)
            {
                return false;
            }

            eventFromDb.CoverImage = updateEventDto.CoverImage;
            eventFromDb.Name = updateEventDto.Name;
            eventFromDb.Description = updateEventDto.Description;
            eventFromDb.CategoryId = updateEventDto.CategoryId;
            eventFromDb.Location = updateEventDto.Location;
            eventFromDb.EventDate = updateEventDto.EventDate;
            eventFromDb.IsPromotion = updateEventDto.IsPromotion;
            eventFromDb.PromotionPlan = updateEventDto.PromotionPlan;

            if (updateEventDto.PublishTime != null)
            {
                eventFromDb.PublishTime = updateEventDto.PublishTime;
            }

            if (eventFromDb.EventDate > DateTime.Now)
            {
                eventFromDb.Status = Status.UPCOMING;
            }
            else if (eventFromDb.EventDate.Year == DateTime.Now.Year &&
                     eventFromDb.EventDate.Month == DateTime.Now.Month &&
                     eventFromDb.EventDate.Day == DateTime.Now.Month)
            {
                eventFromDb.Status = Status.OPENING;
            }
            else
            {
                eventFromDb.Status = Status.CLOSED;
            }

            eventFromDb.UpdatedAt = DateTime.Now;

            await _ticketService.UpdateTicketDetailByEventId(eventId, new CreateTicketDetailDto
            {
                EventId = eventId,
                IsPaid = updateEventDto.TicketIsPaid,
                Price = updateEventDto.TicketPrice ?? 0,
                Quantity = updateEventDto.TicketQuantity,
                StartTime = updateEventDto.TicketStartTime,
                CloseTime = updateEventDto.TicketCloseTime,
            });

            await _albumService.RemoveImagesFromAlbum(eventFromDb.Id);

            await _albumService.AddImagesToAlbum(eventId, updateEventDto.Album);

            await _db.SaveChangesAsync();

            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<bool> DeleteEvent(int eventId)
    {
        try
        {
            var eventFromDb = _db.Events.FirstOrDefault(u => u.Id == eventId);

            if (eventFromDb is null)
            {
                return false;
            }

            _db.Events.Remove(eventFromDb);
            _db.SaveChanges();

            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<bool> IncreaseFavourite(int id)
    {
        try
        {
            var eventFromDb = _db.Events.FirstOrDefault(u => u.Id == id);

            if (eventFromDb is null)
            {
                return false;
            }

            eventFromDb.Favourite++;
            _db.SaveChanges();

            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<bool> DecreaseFavourite(int id)
    {
        try
        {
            var eventFromDb = _db.Events.FirstOrDefault(u => u.Id == id);

            if (eventFromDb is null)
            {
                return false;
            }

            if (eventFromDb.Favourite > 0)
            {
                eventFromDb.Favourite--;
            }

            _db.SaveChanges();

            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<bool> IncreaseShare(int id)
    {
        try
        {
            var eventFromDb = _db.Events.FirstOrDefault(u => u.Id == id);

            if (eventFromDb is null)
            {
                return false;
            }

            eventFromDb.Share++;
            _db.SaveChanges();

            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<bool> DecreaseShare(int id)
    {
        try
        {
            var eventFromDb = _db.Events.FirstOrDefault(u => u.Id == id);

            if (eventFromDb is null)
            {
                return false;
            }

            if (eventFromDb.Share > 0)
            {
                eventFromDb.Share--;
            }

            _db.SaveChanges();

            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}