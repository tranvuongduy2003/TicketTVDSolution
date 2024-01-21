using TicketTVD.Services.EventAPI.Models.Dto;

namespace TicketTVD.Services.EventAPI.Services.IServices;

public interface IAlbumService
{
    Task<IEnumerable<AlbumDto>> GetAlbums();
    Task<IEnumerable<AlbumDto>> GetAlbumsByEventId(int eventId);
    Task<bool> AddImagesToAlbum(int eventId, IEnumerable<string> images);
    Task<bool> RemoveImagesFromAlbum(int eventId);
}