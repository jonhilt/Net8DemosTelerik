using System.Net.Http.Json;
using BlazorDemoApp.Shared.Data;

namespace BlazorDemoApp.Client;

public class ClientProductStore : IProductStore
{
    private readonly HttpClient _httpClient;

    public ClientProductStore(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<RelatedProductsList?> ListRelated(int productId, int pageNumber)
    {
        var uri = $"/api/products/related?productId={productId}&pageNumber={pageNumber}";
        return await _httpClient.GetFromJsonAsync<RelatedProductsList>(uri);
    }

    public List<ProductSummary> List()
    {
        throw new NotImplementedException();
    }

    public ProductDetails Get(int id)
    {
        throw new NotImplementedException();
    }
}