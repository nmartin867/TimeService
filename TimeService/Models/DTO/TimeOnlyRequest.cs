using System.ComponentModel.DataAnnotations;
using NodaTime;

namespace TimeService.Models.DTO;

public class TimeOnlyRequest
{
    [Required]
    public LocalDate Time { get; set; }
}