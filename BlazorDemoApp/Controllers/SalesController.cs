using Microsoft.AspNetCore.Mvc;

namespace BlazorDemoApp.Controllers;

[ApiController]
[Route("[controller]")]
public class SalesController : ControllerBase
{
    [HttpGet]
    public IActionResult Index()
    {
        var sales = GetDemoSales();
        return Ok(sales);
    }

    private static List<Sale> GetDemoSales()
    {
        var sales = new List<Sale>
        {
            new() { Amount = 100, Item = "Shoes" },
            new() { Amount = 200, Item = "Shirt" }
        };
        return sales;
    }

    private class Sale
    {
        public string Item { get; set; }
        public double Amount { get; set; }
    }
}