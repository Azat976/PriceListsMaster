using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace WebApp.Models
{
    public class PriceDbInitializer : DropCreateDatabaseAlways<PriceContext>
    {
        protected override void Seed(PriceContext context)
        {
            Price s1 = new Price { Id = 1, Name = "Егор"};
            Price s2 = new Price { Id = 2, Name = "Мария" };
            Price s3 = new Price { Id = 3, Name = "Олег" };
            Price s4 = new Price { Id = 4, Name = "Ольга" };

            context.Prices.Add(s1);
            context.Prices.Add(s2);
            context.Prices.Add(s3);
            context.Prices.Add(s4);

            PriceList c1 = new PriceList
            {
                Id = 1,
                Name = "Операционные системы",
                Code = "3123",
                Prices = new List<Price>() { s1, s2, s3 }
            };
            PriceList c2 = new PriceList
            {
                Id = 2,
                Name = "Алгоритмы и структуры данных",
                Code = "23233",
                Prices = new List<Price>() { s2, s4 }
            };
            PriceList c3 = new PriceList
            {
                Id = 3,
                Name = "Основы HTML и CSS",
                Code = "31111111123",
                Prices = new List<Price>() { s3, s4, s1 }
            };

            context.PriceLists.Add(c1);
            context.PriceLists.Add(c2);
            context.PriceLists.Add(c3);

            base.Seed(context);
        }

    }
}