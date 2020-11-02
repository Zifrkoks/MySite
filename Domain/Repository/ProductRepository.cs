using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySite.Domain.Interfaces;
using MySite.Models;

namespace MySite.Domain.Repository
{
    public class ProductRepository : IProductRepository
    {
        DataContext Db;

        public ProductRepository(DataContext datacontext)
        {
            Db = datacontext;
        }
        public void AddProduct(Product p)
        {
            if (Db.Products.Any(prod => prod.Name != p.Name))
                Db.Products.Add(p);
                
        }

        public void DeleteProduct(int ID)
        {
            Db.Products.Remove(Db.Products.FirstOrDefault(p => p.ProductId == ID));
        }

        public List<Product> GetAllProducts()
        {
            return Db.Products.ToList();
        }

        public Product GetProduct(int ID)
        {
            return Db.Products.FirstOrDefault(p => p.ProductId == ID);
        }
    }
}
