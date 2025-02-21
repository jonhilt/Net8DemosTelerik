using System.ComponentModel.DataAnnotations;

namespace BlazorDemoApp.Data;

public class NewsletterForm
{
    [Required]
    public string Email { get; set; }
}