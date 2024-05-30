using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    // private readonly ApplicationContext _context;
    private readonly IProductService _productService;

    public ProductController(/*ApplicationContext context*/ IProductService productService) // Here we are injecting the context to give access to the database
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var products = _productService.Get();
        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute]long id)
    {
        var product = _productService.Get(id);

        if (product is null)
        {
            return NotFound(Messages.ProductNotFound);
        }

        return Ok(product);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody]PostPutDto productDto)
    {
        var newProduct = _productService.Save(productDto);
        return Ok(newProduct);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put([FromRoute]long id, [FromBody] PostPutDto productDto)
    {
        var existingProduct = _productService.Update(id, productDto);

        if (existingProduct is null)
        {
            return NotFound(Messages.ProductNotFound);
        }

        return Ok(existingProduct);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute]long id)
    {
        var existingProduct = _productService.Delete(id);

        if (existingProduct is null)
        {
            return NotFound(Messages.ProductNotFound);
        }

        return Ok(existingProduct);
    }
}