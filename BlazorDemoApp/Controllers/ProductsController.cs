using BlazorDemoApp.Shared.Data;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemoApp.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductStore _store;

    public ProductsController(IProductStore store)
    {
        _store = store;
    }

    [HttpGet("related")]
    public async Task<IActionResult> Related([FromQuery]int productId, [FromQuery] int pageNumber)
    {
        return Ok(await _store.ListRelated(productId, pageNumber));
    }
}