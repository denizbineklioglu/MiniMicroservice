using System.ComponentModel.DataAnnotations;

namespace Demo.ProductAPI.Model
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public IList<Product> Products { get; set; }
    }
}
