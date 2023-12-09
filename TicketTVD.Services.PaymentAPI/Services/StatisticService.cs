﻿using AutoMapper;
using Microsoft.Azure.Amqp.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using TicketTVD.Services.PaymentAPI.Data;
using TicketTVD.Services.PaymentAPI.Models;
using TicketTVD.Services.PaymentAPI.Models.Dto;
using TicketTVD.Services.PaymentAPI.Services.IServices;

namespace TicketTVD.Services.PaymentAPI.Services;

public class StatisticService : IStatisticService
{
    private readonly ApplicationDbContext _db;
    private readonly IMapper _mapper;

    public StatisticService(ApplicationDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task<IEnumerable<Revenue>> GetGeneralStatistic()
    {
        try
        {
            var monthList = new List<Payment>()
            {
                new Payment { CreatedAt = new DateTime(DateTime.Now.Year, 1, 1), TotalPrice = 0 },
                new Payment { CreatedAt = new DateTime(DateTime.Now.Year, 2, 1), TotalPrice = 0 },
                new Payment { CreatedAt = new DateTime(DateTime.Now.Year, 3, 1), TotalPrice = 0 },
                new Payment { CreatedAt = new DateTime(DateTime.Now.Year, 4, 1), TotalPrice = 0 },
                new Payment { CreatedAt = new DateTime(DateTime.Now.Year, 5, 1), TotalPrice = 0 },
                new Payment { CreatedAt = new DateTime(DateTime.Now.Year, 6, 1), TotalPrice = 0 },
                new Payment { CreatedAt = new DateTime(DateTime.Now.Year, 7, 1), TotalPrice = 0 },
                new Payment { CreatedAt = new DateTime(DateTime.Now.Year, 8, 1), TotalPrice = 0 },
                new Payment { CreatedAt = new DateTime(DateTime.Now.Year, 9, 1), TotalPrice = 0 },
                new Payment { CreatedAt = new DateTime(DateTime.Now.Year, 10, 1), TotalPrice = 0 },
                new Payment { CreatedAt = new DateTime(DateTime.Now.Year, 11, 1), TotalPrice = 0 },
                new Payment { CreatedAt = new DateTime(DateTime.Now.Year, 12, 1), TotalPrice = 0 },
            };

            var statistic = (from m in monthList
                    from p in _db.Payments
                    where p.CreatedAt.Year == DateTime.Now.Year
                    select new Payment
                    {
                        CreatedAt = m.CreatedAt,
                        TotalPrice = m.CreatedAt.Month == p.CreatedAt.Month ? p.TotalPrice : m.TotalPrice
                    })
                .GroupBy(p => p.CreatedAt.Month)
                .Select(pl => new Revenue
                {
                    Month = pl.Key,
                    Value = pl.Sum(p => p.TotalPrice),
                });

            return statistic;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}