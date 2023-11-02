using AutoMapper;
using TicketTVD.Services.TicketAPI.Models;
using TicketTVD.Services.TicketAPI.Models.Dto;

namespace TicketTVD.Services.TicketAPI;

public class MappingConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(config =>
        {
            config.CreateMap<TicketDto, Ticket>().ReverseMap();
            config.CreateMap<TicketDetailDto, TicketDetail>().ReverseMap();
            config.CreateMap<CreateTicketDetailDto, TicketDetail>();
        });
        return mappingConfig;
    }
}