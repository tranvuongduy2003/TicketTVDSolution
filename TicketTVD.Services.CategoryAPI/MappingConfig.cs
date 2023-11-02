using AutoMapper;
using TicketTVD.Services.CategoryAPI.Models;
using TicketTVD.Services.CategoryAPI.Models.Dto;

namespace TicketTVD.Services.CategoryAPI;

public class MappingConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(config =>
        {
            config.CreateMap<Category, CategoryDto>().ReverseMap();
            config.CreateMap<CreateCategoryDto, Category>();
        });
        return mappingConfig;
    }
}