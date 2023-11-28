﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using TicketTVD.Services.EventAPI.Models.Enum;

namespace TicketTVD.Services.EventAPI.Models.Dto;

public class CreateEventDto
{
    public string CoverImage { get; set; }
    
    public string Name { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
    public IEnumerable<string> Album { get; set; }
    
    public string Location { get; set; }
    public DateTime EventDate { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    
    public bool TicketIsPaid { get; set; }
    public int TicketQuantity { get; set; }
    public decimal? TicketPrice { get; set; } = 0;
    public DateTime TicketStartTime { get; set; }
    public DateTime TicketCloseTime { get; set; }
    
    public Boolean IsPromotion { get; set; }
    public int? PromotionPlan { get; set; } = 0;

    public DateTime? PublishTime { get; set; } = null;
    
    public string CreatorId { get; set; }
}