using System.Drawing;

namespace PustokMVC.Models
{
    public class ProductImages
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public int Productid { get; set; }
        public string Product { get; set; }
        public bool IsActive { get; set; }
    }
}
