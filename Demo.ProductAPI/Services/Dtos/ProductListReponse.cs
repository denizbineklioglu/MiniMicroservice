using Demo.ProductAPI.Model;

namespace Demo.ProductAPI.Services.Dtos
{
    public class ProductListReponse
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public Category category { get; set; }
}
    }
