using AFC.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFC.Repository
{
    public class ClientsAccessor : IRepository<Client>
    {
        private MyDbContext db;
        public ClientsAccessor(MyDbContext db)
        {
            this.db = db;
        }
        public void Create(Client item)
        {
            db.Clients.Add(item);
        }
        public IEnumerable<Client> GetList()
        {
            return db.Clients.ToArray();
        }
        public Client Get(int id)
        {
            return db.Clients.FirstOrDefault(o => o.Id == id);
        }
        public void Update(Client item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            Client client = Get(id);
            if (client != null)
                db.Clients.Remove(client);
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
