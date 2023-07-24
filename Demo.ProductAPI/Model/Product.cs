﻿using System.ComponentModel.DataAnnotations;

namespace Demo.ProductAPI.Model
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
