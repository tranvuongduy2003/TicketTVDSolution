using TicketTVD.Services.CategoryAPI.Models.Dto;

namespace TicketTVD.Services.CategoryAPI.Services.IServices;

public interface ICategoryService
{
    Task<IEnumerable<CategoryDto>> GetCategories();
    Task<CategoryDto?> GetCategoryById(int categoryId);
    Task<bool> CreateCategory(CreateCategoryDto createCategoryDto);
    Task<bool> UpdateCategory(int categoryId, CreateCategoryDto updateCategoryDto);
    Task<bool> DeleteCategory(int categoryId);
}