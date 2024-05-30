public interface IProductService
{
    IEnumerable<Product> Get();
    Product Get(long id);
    Product Save(PostPutDto productDto);
    Product Update(long id, PostPutDto productDto);
    Product Delete(long id);
}