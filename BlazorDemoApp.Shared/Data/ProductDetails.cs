namespace BlazorDemoApp.Shared.Data;

public record ProductDetails
{
    public int Id { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }

    public string Image { get; set; }
    public List<string> Images { get; set; }
    public string Description { get; set; }
}