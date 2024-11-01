using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace ThamCo.productsApiService.Services.Products
{
    public class Products
    {
    [Key]
    public int ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;
   
    public double Price { get; set; }
    public string Description { get; set; } = string.Empty;
    }
}