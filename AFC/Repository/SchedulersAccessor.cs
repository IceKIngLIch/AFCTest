using AFC.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFC.Repository
{
    public class SchedulersAccessor : IRepository<Schedule>
    {
        private MyDbContext db;
        public SchedulersAccessor(MyDbContext db)
        {
            this.db = db;
        }
        public void Create(Schedule item)
        {
            db.Schedulers.AddAsync(item);
        }
        public IEnumerable<Schedule> GetList()
        {
            return db.Schedulers.ToArray();
        }
        public Schedule Get(int id)
        {
            return db.Schedulers.FirstOrDefault(o => o.Id == id);
        }
        public void Update(Schedule item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            Schedule schedule = Get(id);
            if (schedule != null)
                db.Schedulers.Remove(schedule);
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
