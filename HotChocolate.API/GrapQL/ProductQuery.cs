using HotChocolate.API.Models;

namespace HotChocolate.API.GrapQL
{
    public class ProductQuery
    {
        public Product GetProducts()
        {
            return new Product
            {
                ProductName = "Test Ürünü",
                Description = "GrapQL Test ürünü",
                Price = 10,
                Stock = 10
            };
        }
    }
}
