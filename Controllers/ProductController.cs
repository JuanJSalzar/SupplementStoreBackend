using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var products = _productService.Get();
        return Ok(products);
    }

    [HttpGet("{id}")]
    public IActionResult Get(long id)
    {
        var product = _productService.Get(id);

        if (product is null)
        {
            return NotFound(Messages.ProductNotFound);
        }

        return Ok(product);
    }

    [HttpPost]
    public IActionResult Post([FromBody]PostPutDto productDto)
    {
        var newProduct = _productService.Save(productDto);
        return Ok(newProduct);
    }

    [HttpPut("{id}")]
    public IActionResult Put(long id, [FromBody] PostPutDto productDto)
    {
        var existingProduct = _productService.Update(id, productDto);

        if (existingProduct is null)
        {
            return NotFound(Messages.ProductNotFound);
        }

        return Ok(existingProduct);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(long id)
    {
        var existingProduct = _productService.Delete(id);

        if (existingProduct is null)
        {
            return NotFound(Messages.ProductNotFound);
        }

        return Ok(existingProduct);
    }
}
