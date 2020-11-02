using MySite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySite.Domain.Interfaces
{
    public interface IOrderRepository
    {
        public Order GetOrder(string ID);
        public void AddOrder(Order Order);
        public void DeleteOrder(string ID);
    }
}
