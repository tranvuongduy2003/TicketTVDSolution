using AutoMapper;
using TicketTVD.Services.PaymentAPI.Models;
using TicketTVD.Services.PaymentAPI.Models.Dto;

namespace TicketTVD.Services.PaymentAPI;

public class MappingConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(config =>
        {
            config.CreateMap<Payment, PaymentDto>().ReverseMap();

            config.CreateMap<CheckoutDto, PaymentDto>()
                .ForMember(dest => dest.Quantity, u => u.MapFrom(src => src.Tickets.Count()))
                .ForMember(dest => dest.CustomerName, u => u.MapFrom(src => src.ContactInfo.FullName))
                .ForMember(dest => dest.CustomerEmail, u => u.MapFrom(src => src.ContactInfo.Email))
                .ForMember(dest => dest.CustomerPhone, u => u.MapFrom(src => src.ContactInfo.PhoneNumber));
            config.CreateMap<PaymentDto, CheckoutDto>();
        });
        return mappingConfig;
    }
}