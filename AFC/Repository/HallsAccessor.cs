using AFC.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFC.Repository
{
    public class HallsAccessor : IRepository<Hall>
    {
        private MyDbContext db;
        public HallsAccessor(MyDbContext db)
        {
            this.db = db;
        }
        public void Create(Hall item)
        {
            db.Halls.AddAsync(item);
        }
        public IEnumerable<Hall> GetList()
        {
            return db.Halls.ToArray();
        }
        public Hall Get(int id)
        {
            return db.Halls.FirstOrDefault(o => o.Id == id);
        }
        public void Update(Hall item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            Hall hall = Get(id);
            if (hall != null)
                db.Halls.Remove(hall);
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
