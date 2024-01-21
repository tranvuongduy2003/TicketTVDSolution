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
            config.CreateMap<TicketDto, Ticket>();
            config.CreateMap<Ticket, TicketDto>().ForMember(tdto => tdto.EventId, t => t.MapFrom(src => src.TicketDetail.EventId));
            config.CreateMap<TicketDetailDto, TicketDetail>().ReverseMap();
            config.CreateMap<CreateTicketDetailDto, TicketDetail>();
        });
        return mappingConfig;
    }
}