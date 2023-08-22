using System.ComponentModel.DataAnnotations;

namespace BlazorDemoApp.Shared.Checkout;

public class PlaceOrderModel
{
    [ValidateComplexType]
    public PlaceOrderCommand Command { get; set; } = new();

}