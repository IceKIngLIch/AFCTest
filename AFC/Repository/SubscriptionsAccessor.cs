using AFC.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFC.Repository
{
    public class SubscriptionsAccessor : IRepository<Subscription>
    {
        private MyDbContext db;
        public SubscriptionsAccessor(MyDbContext db)
        {
            this.db = db;
        }
        public void Create(Subscription item)
        {
            db.Subscriptions.AddAsync(item);
        }
        public IEnumerable<Subscription> GetList()
        {
            return db.Subscriptions.ToArray();
        }
        public Subscription Get(int id)
        {
            return db.Subscriptions.FirstOrDefault(o => o.Id == id);
        }
        public void Update(Subscription item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            Subscription subscription = Get(id);
            if (subscription != null)
                db.Subscriptions.Remove(subscription);
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
