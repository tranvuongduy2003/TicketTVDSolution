using AutoMapper;
using Microsoft.AspNetCore.Identity;
using TicketTVD.Services.EventAPI.Data;
using TicketTVD.Services.EventAPI.Models;
using TicketTVD.Services.EventAPI.Models.Dto;
using TicketTVD.Services.EventAPI.Services.IServices;

namespace TicketTVD.Services.EventAPI.Services;

public class EventService : IEventService
{
    private readonly ApplicationDbContext _db;
    private readonly IMapper _mapper;
    private readonly ITicketService _ticketService;

    public EventService(ApplicationDbContext db, IMapper mapper, ITicketService ticketService)
    {
        _db = db;
        _mapper = mapper;
        _ticketService = ticketService;
    }
    
    public async Task<IEnumerable<EventDto>> GetEvents()
    {
        try
        {
            var events = _db.Events.ToList();
            var eventDtos = _mapper.Map<IEnumerable<EventDto>>(events);
            
            foreach (var eventDto in eventDtos)
            {
                var ticketDetailDto = await _ticketService.GetTicketDetailByEventId(eventDto.Id);
                eventDto.TicketPrice = ticketDetailDto.Price;
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
            var ticketDetailDto = await _ticketService.GetTicketDetailByEventId(eventDto.Id);
            eventDto.TicketPrice = ticketDetailDto.Price;
            eventDto.TicketIsPaid = ticketDetailDto.IsPaid;
            eventDto.TicketQuantity = ticketDetailDto.Quantity;
            eventDto.TicketStartTime = ticketDetailDto.StartTime;
            eventDto.TicketCloseTime = ticketDetailDto.CloseTime;

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
            newEvent.CreatedAt = DateTime.Now;
            newEvent.UpdatedAt = DateTime.Now;
            
            _db.Events.AddAsync(newEvent);
            
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
            eventFromDb.Status = updateEventDto.Status;
            eventFromDb.Album = updateEventDto.Album;
            eventFromDb.Location = updateEventDto.Location;
            eventFromDb.EventDate = updateEventDto.EventDate;
            eventFromDb.StartTime = updateEventDto.StartTime;
            eventFromDb.EndTime = updateEventDto.EndTime;
            eventFromDb.IsPromotion = updateEventDto.IsPromotion;
            eventFromDb.PromotionPlan = updateEventDto.PromotionPlan;
            eventFromDb.PublishTime = updateEventDto.PublishTime;
            eventFromDb.CreatorId = updateEventDto.CreatorId;
            eventFromDb.UpdatedAt = DateTime.Now;
            
            _db.SaveChanges();
            
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
}