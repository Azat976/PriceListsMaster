using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Price
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public string City { get; set; }
        //public string Country { get; set; }
  
        //public string Column1 { get; set; }
        //public string Column2 { get; set; }
        //public string Column3 { get; set; }
        //public string Column4 { get; set; }
        //public string Column5 { get; set; }
        //public string Column6 { get; set; }
        //public string Column7 { get; set; }
        //public string Column8 { get; set; }
        //public int? PriceListId { get; set; }
        public PriceList PriceList { get; set; }
        public ICollection<PriceList> PriceLists { get; set; }
        internal void CreatePhoneNumbers(int count = 1)
        {
            for (int i = 0; i < count; i++)
            {
                PriceLists.Add(new PriceList());
            }
        }
        public Price()
        {
            PriceLists = new List<PriceList>();
        }
    }
}