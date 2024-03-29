﻿namespace PustokMVC.ViewModels.BasketVM
{
    public class BasketProductItemVM
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public float Discount { get; set; } 
    }
}
