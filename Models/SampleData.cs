using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MySite.Models
{
    public static class SampleData
    {
        public static void Initialize(DataContext Context)
        {
            if (!Context.Products.Any())
            {
                Context.Products.AddRange
                    (
                    new Product { Name = "ганджа", Price = 1200, Rating = 9.99f, CountOrders = 100000},
                    new Product { Name = "Марина Ивановна(или мариуана)", Price = 900, Rating = 9.99f, CountOrders = 100000},
                    new Product { Name = "LSD", Price = 1500, Rating = 9.99f, CountOrders = 100000}
                    );
                    Context.SaveChanges();
            }
        }
    }   
}
