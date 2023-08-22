using BlazorDemoApp.Shared.Checkout;

namespace BlazorDemoApp.Shared.Data;

public interface IProductStore
{
    Task<RelatedProductsList?> ListRelated(int productId, int pageNumber);
    List<ProductSummary> List();
    ProductDetails Get(int id);
    PlaceOrderCommand GetCheckout();
}