using ProductsDay5.Model;

namespace ProductsDay5.Repository
{
    public class ProductRepository
    {
        private readonly List<Product> products;

        public ProductRepository()
        {
            // Initialize with some sample data
            products = new List<Product>
        {
            new Product { ProductId = 1, ProductName = "Dress", ProductBrand = "Biba", ProductQuantity = 5, ProductPrice = 2000.0m },
            new Product { ProductId = 2, ProductName = "Book", ProductBrand = "Three Mistakes", ProductQuantity = 2, ProductPrice = 200.0m }
        };
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetProductById(int productId)
        {
            return products.FirstOrDefault(p => p.ProductId == productId);
        }

        public List<Product> GetProductsByName(string productName)
        {
            return products.Where(p => p.ProductName.Contains(productName, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public Product AddProduct(Product product)
        {
            product.ProductId = products.Count + 1;
            products.Add(product);
            return product;

        }

        public Product UpdateProduct(int productId, Product updatedProduct)
        {
            var existingProduct = products.FirstOrDefault(p => p.ProductId == productId);
            if (existingProduct != null)
            {
                existingProduct.ProductName = updatedProduct.ProductName;
                existingProduct.ProductBrand = updatedProduct.ProductBrand;
                existingProduct.ProductQuantity = updatedProduct.ProductQuantity;
                existingProduct.ProductPrice = updatedProduct.ProductPrice;
                return existingProduct;
            }
            return null;
        }

        public string DeleteProduct(int productId)
        {
            var productToRemove = products.FirstOrDefault(p => p.ProductId == productId);
            if (productToRemove != null)
            {
                products.Remove(productToRemove);
                return productToRemove.ProductName;
            }
            return null;
        }
    }

}

