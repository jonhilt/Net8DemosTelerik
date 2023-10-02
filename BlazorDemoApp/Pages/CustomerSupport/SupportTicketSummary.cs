namespace BlazorDemoApp.Pages.CustomerSupport;

public record SupportTicketSummary()
{
    public string Subject { get; set; }
    public string Department { get; set; }
    public string Status { get; set; }
}