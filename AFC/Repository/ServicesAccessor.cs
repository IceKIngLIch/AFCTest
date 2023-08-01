using AFC.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFC.Repository
{
    public class ServicesAccessor : IRepository<Service>
    {
        private MyDbContext db;
        public ServicesAccessor(MyDbContext db)
        {
            this.db = db;
        }
        public void Create(Service item)
        {
            db.Services.AddAsync(item);
        }
        public IEnumerable<Service> GetList()
        {
            return db.Services.ToArray();
        }
        public Service Get(int id)
        {
            return db.Services.FirstOrDefault(o => o.Id == id);
        }
        public void Update(Service item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            Service services = Get(id);
            if (services != null)
                db.Services.Remove(services);
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
