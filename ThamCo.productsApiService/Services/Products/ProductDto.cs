

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ThamCo.productsApiService.Services.Products
{
    public class ProductDto
    {
    [Key]
    public int ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;

    public double Price { get; set; }
    public string Description { get; set; } = string.Empty;

        
    }
}