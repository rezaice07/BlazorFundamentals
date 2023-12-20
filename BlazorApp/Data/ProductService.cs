namespace BlazorApp.Data
{
    public class ProductService
    {
        List<Product> products = new List<Product>()
        {
            new Product() {ProductId="101", ProductName="Laptop", Price=50000}, 
            new Product() {ProductId="102", ProductName="Mouse", Price=500},
            new Product(){ProductId="103", ProductName="Keyboard", Price=250},
            new Product(){ProductId="104", ProductName="Pendrive", Price=2000},
            new Product() {ProductId="105", ProductName="Monitor", Price=9000 },
            new Product() {ProductId="106", ProductName="Cable", Price=300}, 
            new Product(){ProductId="107", ProductName="Computer", Price=40000}
        };

        public async Task<List<Product>> ProductList()
        {
            return
            await Task.FromResult(products);
        }
    }
}
