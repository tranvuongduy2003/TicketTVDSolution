using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using TicketTVD.Services.TicketAPI.Models.Enum;

namespace TicketTVD.Services.TicketAPI.Models;

public class Ticket
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int TicketDetailId { get; set; }
    public string? TicketCode { get; set; }
    public string OwnerName { get; set; }
    public string OwnerEmail { get; set; }
    public string OwnerPhone { get; set; }
    public int PaymentId { get; set; }
    public bool IsPaid { get; set; }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TicketStatus Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    [ForeignKey("TicketDetailId")] 
    public virtual TicketDetail TicketDetail { get; set; }
}