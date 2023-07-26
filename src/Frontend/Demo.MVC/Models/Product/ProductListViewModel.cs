namespace Demo.MVC.Models.Product
{
    public class ProductListViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public string ImageUrl { get; set; }
        public CategoryViewModel Category { get; set; }
    }
}
