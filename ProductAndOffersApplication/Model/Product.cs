using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductAndOffersApplication.Model
{
    public class Product
    {
        public string ProductName { get; set; }
        public Decimal Price { get; set; }
        public string Description { get; set; }
    }
}