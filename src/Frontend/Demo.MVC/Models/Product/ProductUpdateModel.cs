using System.ComponentModel.DataAnnotations;

namespace Demo.MVC.Models.Product
{
    public class ProductUpdateModel
    {
        public int ProductID { get; set; }

        [Display(Name ="Ürün Adı")]
        public string ProductName { get; set; }

        [Display(Name = "Fiyat")]
        public double Price { get; set; }

        [Display(Name = "Miktar")]
        public double Quantity { get; set; }

        [Display(Name = "Resim")]
        public string ImageUrl { get; set; }

        [Display(Name = "Kategori")]
        public int CategoryID { get; set; }
    }
}
