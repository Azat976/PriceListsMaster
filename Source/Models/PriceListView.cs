using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class PriceListView
    {
        public IEnumerable<Price> Prices { get; set; }
        public IEnumerable<PriceList> PriceLists { get; set; }
    }
}