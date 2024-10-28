

using ThamCo.productsApiService.Services.Products;

namespace ThamCo.productsApiService;
public interface IProductService
{
     Task<IEnumerable<ProductDto>> GetProductsAsync();
    Task<ProductDto> GetProductAsync(int id);
}
