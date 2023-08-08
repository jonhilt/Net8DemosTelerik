namespace BlazorDemoApp.Shared.Data;

public record Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }

    public List<string> Images { get; set; }
    public List<int> Related { get; set; } = new();
    public string Description { get; set; }
}