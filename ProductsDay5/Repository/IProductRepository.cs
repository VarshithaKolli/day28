using ProductsDay5.Model;

namespace ProductsDay5.Repository
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product GetProductById(int productId);
        List<Product> GetProductsByName(string productName);
        Product AddProduct(Product product);
        Product UpdateProduct(int productId, Product updatedProduct);
        string DeleteProduct(int productId);

    }
}
