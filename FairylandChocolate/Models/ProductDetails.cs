using System;
namespace FairylandChocolate.Models
{
    public class ProductDetails
    {
        public ProductDetails()
        {
        }
        public int ProductId
        {
            get;
            set;
        }
		public string ProductName
		{
			get;
			set;
		}
        public decimal Price
		{
			get;
			set;
		}
		public string Size
		{
			get;
			set;
		}
        public decimal Weight
		{
			get;
			set;
		}
        public int NoOfChocolates
		{
			get;
			set;
		}
        public string ProductInfo
		{
			get;
			set;
		}


	}
}
