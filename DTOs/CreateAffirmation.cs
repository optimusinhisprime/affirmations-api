using System.ComponentModel.DataAnnotations;

namespace AffirmationsAPI.DTOs;

public class CreateAffirmationDto
{
    [Required]
    [StringLength(200)]
    public string Title { get; set; } = string.Empty;

    [Required]
    [StringLength(1000)]
    public string Body { get; set; } = string.Empty;

    [StringLength(100)]
    public string? Author { get; set; }
}
