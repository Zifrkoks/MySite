using MySite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySite.Domain.Interfaces
{
    public interface IClientRepository
    {
        public Client GetClient(int ID);
        public Client GetClient(string Login);
        public void DeleteClient(int ID);
        public void DeleteClient(string Login);
        public bool AddClient(Client client);
    }
}
