using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThamCo.productsApiService.Services.Products
{
    public class Products
    {
    public int ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;

    public decimal Price { get; set; }
    public string Description { get; set; } = string.Empty;
    }
}