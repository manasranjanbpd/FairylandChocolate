using System;
using System.Collections.Generic;

namespace FairylandChocolate.Models
{
    public class CategoryModel
    {
        public CategoryModel()
        {
        }
		public string CategoryId { get; set; }
		public string CategoryName { get; set; }
        public List<ProductModel> AllProducts
        {
            get;
            set;
        }
    }
}
