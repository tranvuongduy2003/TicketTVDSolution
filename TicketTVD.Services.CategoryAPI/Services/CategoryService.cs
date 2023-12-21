using AutoMapper;
using TicketTVD.Services.CategoryAPI.Data;
using TicketTVD.Services.CategoryAPI.Models;
using TicketTVD.Services.CategoryAPI.Models.Dto;
using TicketTVD.Services.CategoryAPI.Services.IServices;

namespace TicketTVD.Services.CategoryAPI.Services;

public class CategoryService : ICategoryService
{
    private readonly ApplicationDbContext _db;
    private readonly IMapper _mapper;

    public CategoryService(ApplicationDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<CategoryDto>> GetCategories()
    {
        try
        {
            var categories = _db.Categories.ToList();
            var categoryDtos = _mapper.Map<IEnumerable<CategoryDto>>(categories);

            return categoryDtos;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<CategoryDto?> GetCategoryById(int categoryId)
    {
        try
        {
            var category = _db.Categories.FirstOrDefault(t => t.Id == categoryId);

            if (category is null)
            {
                return null;
            }
            
            var categoryDto = _mapper.Map<CategoryDto>(category);

            return categoryDto;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<bool> CreateCategory(CreateCategoryDto createCategoryDto)
    {
        try
        {
            var category = _db.Categories.FirstOrDefault(c => c.Name == createCategoryDto.Name);

            if (category != null)
            {
                return false;
            }
            
            var newCategory = _mapper.Map<Category>(createCategoryDto);
            
            newCategory.CreatedAt = DateTime.Now;
            newCategory.UpdatedAt = DateTime.Now;
            
            _db.Categories.AddAsync(newCategory);
            _db.SaveChanges();
            
            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<bool> UpdateCategory(int categoryId, CreateCategoryDto updateCategoryDto)
    {
        try
        {
            var category = _db.Categories.FirstOrDefault(c => c.Id == categoryId);

            if (category is null)
            {
                return false;
            }

            category.Name = updateCategoryDto.Name;
            category.Color = updateCategoryDto.Color;
            category.UpdatedAt = DateTime.Now;
            
            _db.SaveChanges();
            
            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<bool> DeleteCategory(int categoryId)
    {
        try
        {
            var category = _db.Categories.FirstOrDefault(c => c.Id == categoryId);

            if (category is null)
            {
                return false;
            }

            _db.Categories.Remove(category);
            
            _db.SaveChanges();
            
            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}