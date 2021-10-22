using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductAndOffersApplication.Model
{
    public class Offers
    {
        public string OfferName { get; set; }
        public List<Product> Product { get; set; }
    }
}