using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class PriceList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Column1 { get; set; }
        public string Column2 { get; set; }
        public string Column3 { get; set; }
        public string Column4 { get; set; }
        public string Column5 { get; set; }
        public string Column6 { get; set; }
        public string Column7 { get; set; }
        public string Column8 { get; set; }
        public int? PriceListId { get; set; }
        public ICollection<Price> Prices { get; set; }
        public PriceList()
        {
            Prices = new List<Price>();
        }

    }
}