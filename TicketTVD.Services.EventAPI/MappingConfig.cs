﻿using AutoMapper;
using TicketTVD.Services.EventAPI.Models;
using TicketTVD.Services.EventAPI.Models.Dto;

namespace TicketTVD.Services.EventAPI;

public class MappingConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(config =>
        {
            config.CreateMap<Event, EventDto>();
            config.CreateMap<DetailEventDto, Event>().ReverseMap();
            config.CreateMap<CreateEventDto, Event>();
            config.CreateMap<UpdateEventDto, Event>();
        });
        return mappingConfig;
    }
}