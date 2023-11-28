namespace TicketTVD.Services.PaymentAPI.Models.Dto;

public class ResponseDto
{
    public object? Data { get; set; }
    public bool IsSuccess { get; set; } = true;
    public string Message { get; set; } = "";
}