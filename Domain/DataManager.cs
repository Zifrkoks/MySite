using MySite.Domain.Interfaces;
using MySite.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySite.Domain
{
    public class DataManager
    {
        public IClientRepository Clients;
        public IProductRepository Products;
        public IOrderRepository Orders;
        public DataManager(IClientRepository _clients, IProductRepository _products, IOrderRepository _orders)
        {
            Clients = _clients;
            Products = _products;
            Orders = _orders;

        }

    }
}
