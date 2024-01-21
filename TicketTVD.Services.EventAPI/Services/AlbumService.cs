using AutoMapper;
using TicketTVD.Services.EventAPI.Data;
using TicketTVD.Services.EventAPI.Models;
using TicketTVD.Services.EventAPI.Models.Dto;
using TicketTVD.Services.EventAPI.Services.IServices;

namespace TicketTVD.Services.EventAPI.Services;

public class AlbumService : IAlbumService
{
    private readonly ApplicationDbContext _db;
    private readonly IMapper _mapper;

    public AlbumService(ApplicationDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<AlbumDto>> GetAlbums()
    {
        try
        {
            var albums = _db.Albums.ToList();
            var albumDtos = _mapper.Map<IEnumerable<AlbumDto>>(albums);

            return albumDtos;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<IEnumerable<AlbumDto>> GetAlbumsByEventId(int eventId)
    {
        try
        {
            var albums = _db.Albums.Where(a => a.EventId == eventId).ToList();
            var albumDtos = _mapper.Map<IEnumerable<AlbumDto>>(albums);

            return albumDtos;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<bool> AddImagesToAlbum(int eventId, IEnumerable<string> images)
    {
        try
        {
            await this.RemoveImagesFromAlbum(eventId);

            var albums = new List<Album>();
            
            await _db.Albums.AddRangeAsync(images.Select(i => new Album
            {
                EventId = eventId,
                Uri = i
            }));

            await _db.SaveChangesAsync();
            
            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<bool> RemoveImagesFromAlbum(int eventId)
    {
        try
        {
            var albums = _db.Albums.Where(a => a.EventId == eventId).ToList();
            
            _db.Albums.RemoveRange(albums);

            await _db.SaveChangesAsync();
            
            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}