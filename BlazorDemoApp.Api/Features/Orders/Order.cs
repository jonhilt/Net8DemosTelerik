namespace BlazorDemoApp.Api.Features.Orders;

public record CreateOrder
{
    public record Command
    {
        public string UserId { get; set; }

        public string ProductId { get; set; }

        public class DeliveryDetails
        {
            public string Address { get; set; }
            public string ContactNumber { get; set; }
        }
    }

    public record Response
    {
        public string OrderId { get; set; }
    }
}

public record CancelOrder
{
    public record Command
    {
        public string OrderId { get; set; }
        public string Reason { get; set; }
    }
}