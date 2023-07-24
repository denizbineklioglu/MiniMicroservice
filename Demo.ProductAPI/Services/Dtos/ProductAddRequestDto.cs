namespace Demo.ProductAPI.Services.dtos
{
    public class ProductAddRequestDto
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryID { get; set; }
    }
}
