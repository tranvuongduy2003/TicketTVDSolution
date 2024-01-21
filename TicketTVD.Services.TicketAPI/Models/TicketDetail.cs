using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketTVD.Services.TicketAPI.Models;

public class TicketDetail
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int EventId { get; set; }
    public int Quantity { get; set; }
    public int SoldQuantity { get; set; }
    public decimal Price { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime CloseTime { get; set; }
    
    // [ForeignKey("EventId")] 
    // public virtual Event Event { get; set; }
}