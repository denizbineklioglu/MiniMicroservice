using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Demo.MVC.Models.Product
{
    public class ProductCreateViewModel
    {
        [Display(Name = "Ürün Adı")]
        public string ProductName { get; set; }

        [Display(Name = "Fiyat")]
        public double Price { get; set; }

        [Display(Name = "Miktar")]
        public double Quantity { get; set; }


        public string ImageUrl { get; set; } = "fdgsfg";

        [Display(Name = "Kategori")]
        public int CategoryID { get; set; }

        [Display(Name = "Resim")]
        public IFormFile Image { get; set; }
    }
}
