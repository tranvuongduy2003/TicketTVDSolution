using AutoMapper;

namespace TicketTVD.Services.EventAPI;

public class MappingConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(config =>
        {
            // config.CreateMap<EventDto, Event>().ReverseMap();
        });
        return mappingConfig;
    }
}