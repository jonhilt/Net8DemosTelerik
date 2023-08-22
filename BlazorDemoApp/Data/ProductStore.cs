using BlazorDemoApp.Shared.Checkout;
using BlazorDemoApp.Shared.Data;

namespace BlazorDemoApp.Data;

public class ProductStore : IProductStore
{
    private readonly List<Product> _products = DemoData.Products();

    public List<ProductSummary> List()
    {
        return _products.Select(x => new ProductSummary
        {
            Id = x.Id,
            Image = x.Images.First(),
            Price = x.Price,
            Title = x.Title
        }).ToList();
    }

    public ProductDetails Get(int id)
    {
        var details = _products.SingleOrDefault(x => x.Id == id);

        return new ProductDetails
        {
            Image = details.Images.First(),
            Id = details.Id,
            Images = details.Images,
            Price = details.Price,
            Title = details.Title,
            Description = details.Description
        };
    }

    public PlaceOrderCommand GetCheckout()
    {
        return new PlaceOrderCommand
        {
            BillingAddress = new PlaceOrderCommand.Address
            {
                Name = "Blanche DuBois",
                AddressLine1 = "A Streetcar",
                AddressLine2 = "Named Desire",
                City = "New Orleans",
                PostCode = "70122"
            },
            Items = new List<PlaceOrderCommand.OrderItem>
            {
                new() { Quantity = 1, SKU = "TSHIRT" }
            }
        };
    }

    public async Task<RelatedProductsList?> ListRelated(int productId, int pageNumber)
    {
        int pageSize = 5;

        var product = _products.SingleOrDefault(x => x.Id == productId);
        var results = new List<ProductSummary>();

        // for demo purposes - in reality would probably have an optimised query to the DB for this
        foreach (var relatedId in product.Related
                     .Skip(pageNumber * pageSize)
                     .Take(pageSize))
        {
            var related = _products.SingleOrDefault(x => x.Id == relatedId);
            results.Add(new ProductSummary
            {
                Id = related.Id,
                Image = related.Images.FirstOrDefault(),
                Price = related.Price,
                Title = related.Title
            });
        }

        return new RelatedProductsList
        {
            Data = results,
            Total = product.Related.Count,
            TotalPages = product.Related.Count / pageSize,
            CurrentPage = pageNumber
        };
    }
}