using System.ComponentModel.DataAnnotations;

namespace BlazorDemoApp.Shared.Checkout;

public record PlaceOrderCommand
{
    public Address BillingAddress { get; set; } = new();
    public Address ShippingAddress { get; set; } = new();
    public List<OrderItem> Items { get; set; } = new();

    public class Address
    {
        [Required]
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        
        [Required]
        public string PostCode { get; set; }
    }

    public class OrderItem
    {
        public string SKU { get; set; }
        public int Quantity { get; set; }
    }
}