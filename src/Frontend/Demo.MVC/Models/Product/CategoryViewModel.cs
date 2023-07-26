namespace Demo.MVC.Models.Product
{
    public class CategoryViewModel
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public IList<ProductListViewModel> Products { get; set; }
    }
}
