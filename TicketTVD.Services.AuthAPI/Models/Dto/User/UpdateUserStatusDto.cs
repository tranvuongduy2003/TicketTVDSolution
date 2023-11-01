using System.Text.Json.Serialization;
using TicketTVD.Services.AuthAPI.Models.Enum;

namespace TicketTVD.Services.AuthAPI.Models.Dto;

public class UpdateUserStatusDto
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Status Status { get; set; }
}