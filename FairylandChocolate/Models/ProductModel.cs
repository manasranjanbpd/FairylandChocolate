using System;
namespace FairylandChocolate.Models
{
    public class ProductModel
    {
        public ProductModel()
        {
        }

        public string ProductName { get; set; }
        public string CategoryName { get;  set; }
        public string ProductImageSrc { get;  set; }
        public string ProductDesc { get;  set; }
		public bool ProductIsActive { get; set; }
        public double ProductPrice { get; set; }
	}
}
