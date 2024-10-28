using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThamCo.productsApiService
{
    Task<IEnumerable<Product>> GetProductsAsync();
    Task<Product> GetProductByIdAsync(int id);
    Task<bool> AddProductAsync(Product product);
    Task<bool> UpdateProductAsync(Product product);
    Task<bool> DeleteProductAsync(int id);
}