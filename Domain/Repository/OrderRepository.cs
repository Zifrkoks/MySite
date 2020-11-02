using MySite.Domain.Interfaces;
using MySite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySite.Domain.Repository
{
    public class OrderRepository : IOrderRepository
    {
        DataContext Db;
        public OrderRepository(DataContext datacontext)
        {
            Db = datacontext;
        }
        public void AddOrder(Order Order)
        {
            Db.Orders.Add(Order);
        }

        public void DeleteOrder(string ID)
        {
            Db.Orders.Remove(Db.Orders.FirstOrDefault(o => o.OrderId == ID));
        }

        public Order GetOrder(string ID)
        {
            return Db.Orders.FirstOrDefault(o => o.OrderId == ID);
        }
    }
}
