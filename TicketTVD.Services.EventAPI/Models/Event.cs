using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using TicketTVD.Services.EventAPI.Models.Enum;

namespace TicketTVD.Services.EventAPI.Models;

public class Event
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string CoverImage { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
    public IEnumerable<string> Album { get; set; }
    public string Location { get; set; }
    public DateTime EventDate { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string CreatorId { get; set; }
    public Boolean IsPromotion { get; set; }
    public int PromotionPlan { get; set; }
    public DateTime PublishTime { get; set; }
    public int Favourite { get; set; }
    public int Share { get; set; }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Status Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    // [ForeignKey("CategoryId")] 
    // public virtual Category Category { get; set; }
    // // [ForeignKey("CreatorId")] 
    // public virtual ApplicationUser Creator { get; set; }
}