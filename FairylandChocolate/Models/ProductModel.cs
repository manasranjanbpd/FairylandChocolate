using System;
using System.Collections.Generic;

namespace FairylandChocolate.Models
{
    public class ProductModel
    {
        public ProductModel()
        {
        }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get;  set; }
        public string ProductImageSrc { get;  set; }
		public List<string> ProductImages { get; set; }
		public List<string> ProductColors { get; set; }
		public string ProductDesc { get;  set; }
		public bool ProductIsActive { get; set; }
        public double ProductPrice { get; set; }
		public int NoOfChocolates { get; set; }
		public ProductDimension ProductDimensions { get; set; }
        public DateTime ProductAddedDate { get; set; }

	}

    public class ProductDimension
    {
        public string Length
        {
            get;
            set;
		}
		public string Breadth
		{
			get;
			set;
		}
		public string Height
		{
			get;
			set;
		}
    }
}
