using MySite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySite.Domain.Interfaces;

namespace MySite.Domain.Repository
{
    public class ClientRepository : IClientRepository
    {
        DataContext Db;

        public ClientRepository(DataContext datacontext)
        {
            Db = datacontext;
        }
        public bool AddClient(Client client)
        {
            if (Db.Clients.Any(c => c.Email != client.Email))
            {
                Db.Clients.Add(client);
                Db.SaveChanges();
                return true;
            }
            else
                return false;
        }


        public void DeleteClient(int ID)
        {
            Db.Clients.Remove(Db.Clients.FirstOrDefault(cl => cl.ClientId == ID));
            Db.SaveChanges();
        }
        public void DeleteClient(string Login)
        {
            Db.Clients.Remove(Db.Clients.FirstOrDefault(cl => cl.Email == Login));
            Db.SaveChanges();
        }

        public Client GetClient(int ID)
        {
            return Db.Clients.FirstOrDefault(cl => cl.ClientId == ID);
        }

        public Client GetClient(string Login)
        {
            return Db.Clients.FirstOrDefault(cl => cl.Email == Login);
        }
    }
}
