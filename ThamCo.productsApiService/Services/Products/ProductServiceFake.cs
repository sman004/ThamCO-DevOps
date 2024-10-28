

namespace ThamCo.productsApiService.Services.Products
{
    public class ProductServiceFake : IProductService
    {
        private readonly List<ProductDto> products = new List<ProductDto>
        {
            new ProductDto { ProductId = 1, ProductName = "Nike Converse", Price = 100, Description = "Go gaga with Nike Converse, made from natural materials" },
            new ProductDto { ProductId = 2, ProductName = "Nike Sweatshirt", Price = 200, Description = "Stay warm and cozy with this sweatshirt made from wool" },
        };

        public Task<IEnumerable<ProductDto>> GetProductsAsync()
        {
            // Return the products list as an asynchronous task
            return Task.FromResult((IEnumerable<ProductDto>)products);
        }

        public Task<ProductDto> GetProductAsync(int id)
        {
            // Retrieve the product by ID
            var product = products.FirstOrDefault(p => p.ProductId == id);

            // Optional: Throw an exception if product is not found
            return Task.FromResult(product ?? throw new KeyNotFoundException($"Product with ID {id} not found."));
        }
    }
}
