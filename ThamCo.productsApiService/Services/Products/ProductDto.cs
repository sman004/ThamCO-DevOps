

namespace ThamCo.productsApiService.Services.Products
{
    public class ProductDto
    {
     public int ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;

    public decimal Price { get; set; }
    public string Description { get; set; } = string.Empty;

        
    }
}