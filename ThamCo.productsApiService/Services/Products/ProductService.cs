

namespace ThamCo.productsApiService.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;

        public ProductService(HttpClient client)
        {
            // Configuring HttpClient with base address and headers
            client.BaseAddress = new Uri("http://localhost:3733/");
            client.Timeout = TimeSpan.FromSeconds(5);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            _client = client;
        }

        public async Task<IEnumerable<ProductDto>> GetProductsAsync()
        {
            var response = await _client.GetAsync("api/products");
            response.EnsureSuccessStatusCode();

            // Using ReadFromJsonAsync for deserialization
            return await response.Content.ReadFromJsonAsync<IEnumerable<ProductDto>>() 
                   ?? new List<ProductDto>(); // Return empty list if null
        }

        public async Task<ProductDto> GetProductAsync(int id)
        {
            var response = await _client.GetAsync($"api/products/{id}");
            response.EnsureSuccessStatusCode();

            // Using ReadFromJsonAsync for deserialization
            return await response.Content.ReadFromJsonAsync<ProductDto>() 
                   ?? throw new HttpRequestException($"Product with ID {id} not found.");
        }
    }
}
