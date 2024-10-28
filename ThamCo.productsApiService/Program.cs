using ThamCo.productsApiService.Services.Products;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddSingleton<ThamCo.productsApiService.IProductService, ProductServiceFake>();
}
else
{
    builder.Services.AddHttpClient<ThamCo.productsApiService.IProductService, ProductService>();
}
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Map MVC controller routes
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Define routing for products API

// Get all products
app.MapGet("/api/products", async (ThamCo.productsApiService.IProductService productService) =>
{
    var products = await productService.GetProductsAsync();
    return Results.Ok(products);
});

// Get a product by ID
app.MapGet("/api/products/{id}", async (int id, ThamCo.productsApiService.IProductService productService) =>
{
    var product = await productService.GetProductAsync(id);
    if (product == null)
    {
        return Results.NotFound(); // Return 404 if product not found
    }
    return Results.Ok(product);
});

// Simple test endpoint
app.MapGet("/", () => "Hello, World!");

app.Run();
