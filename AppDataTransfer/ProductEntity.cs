﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataTransfer
{
    public class ProductEntity
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Keywords { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int IsActive { get; set; }
        public int UnitCost { get; set; }
        public int UnitPrice { get; set; }
        public int CategoryId { get; set; }
        public string LastModified { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
