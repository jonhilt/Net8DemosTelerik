namespace BlazorDemoApp.Api.Features.Orders;

public static class OrderEndpoints
{
    public static void MapOrderEndpoints(this WebApplication webApp)
    {
        webApp.MapPost("/order", CreateOrder);
        webApp.MapPut("/order/cancel", CancelOrder);
    }

    private static IResult CancelOrder(HttpContext context, CancelOrder.Command cancelOrderCommand)
    {
        Console.WriteLine("Deleting order");
        return Results.Ok();
    }

    private static IResult CreateOrder(HttpContext context, CreateOrder.Command createOrderCommand)
    {
        Console.WriteLine("Creating order");
        Console.WriteLine(createOrderCommand);

        return Results.Ok();
    }
}