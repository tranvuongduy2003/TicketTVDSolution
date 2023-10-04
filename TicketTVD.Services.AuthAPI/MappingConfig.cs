using AutoMapper;
using TicketTVD.Services.AuthAPI.Models;
using TicketTVD.Services.AuthAPI.Models.Dto;

namespace TicketTVD.Services.AuthAPI;

public class MappingConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(config =>
        {
            config.CreateMap<ApplicationUser, UserDto>().ReverseMap();
        });
        return mappingConfig;
    }
}