﻿namespace TicketTVD.Services.EventAPI.Models.Dto;

public class TicketDetailDto
{
    public int Id { get; set; }
    public int EventId { get; set; }
    public bool IsPaid { get; set; }
    public int Quantity { get; set; }
    public int SoldQuantity { get; set; }
    public decimal Price { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime CloseTime { get; set; }
}