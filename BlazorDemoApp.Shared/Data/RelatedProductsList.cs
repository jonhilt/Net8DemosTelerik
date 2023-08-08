namespace BlazorDemoApp.Shared.Data;

public record RelatedProductsList()
{
    public List<ProductSummary> Data { get; set; } = new();
    public int Total { get; set; }
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
}