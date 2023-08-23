using System.ComponentModel.DataAnnotations;

namespace BlazorDemoApp.Pages.Customers;

public record CustomerInvite
{
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string Email { get; set; }
}