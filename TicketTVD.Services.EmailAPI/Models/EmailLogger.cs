using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketTVD.Services.EmailAPI.Models;

public class EmailLogger
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Email { get; set; }
    public string Message { get; set; }
    public DateTime? EmailSent { get; set; }
}