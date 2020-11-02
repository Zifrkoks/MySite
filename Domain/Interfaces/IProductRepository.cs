using MySite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySite.Domain.Interfaces
{
    public interface IProductRepository
    {
        public void AddProduct(Product p);
        public void DeleteProduct(int ID);
        public Product GetProduct(int ID);
        public List<Product> GetAllProducts();
    }
}
