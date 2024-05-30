public class ProductService : IProductService
{
    private readonly ApplicationContext _context;

    public ProductService(ApplicationContext context)
    {
        _context = context;
    }

    public IEnumerable<Product> Get()
    {
        return _context.Products.OrderByDescending(p => p.UpdatedAt).ToList();
    }

    public Product Get(long id)
    {
        return _context.Products.Find(id);
    }

    public Product Save(PostPutDto productDto)
    {
        var newProduct = new Product
        {
            Brand = productDto.Brand,
            Title = productDto.Title
        };

        _context.Products.Add(newProduct);
        _context.SaveChanges();
        return newProduct;
    }

    public Product Update(long id, PostPutDto productDto)
    {
        var existingProduct = _context.Products.Find(id);

        if (existingProduct is null)
        {
            return null;
        }

        existingProduct.Brand = productDto.Brand;
        existingProduct.Title = productDto.Title;
        existingProduct.UpdatedAt = DateTime.Now;

        _context.Products.Update(existingProduct);
        _context.SaveChanges();
        return existingProduct;
    }

    public Product Delete(long id)
    {
        var existingProduct = _context.Products.Find(id);

        if (existingProduct is null)
        {
            return null;
        }

        _context.Products.Remove(existingProduct);
        _context.SaveChanges();
        return existingProduct; 
    }

}