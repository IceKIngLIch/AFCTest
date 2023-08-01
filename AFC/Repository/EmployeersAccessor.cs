using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFC.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace AFC.Repository
{
    public class EmployeersAccessor : IRepository<Employee>
    {
        private MyDbContext db;
        public EmployeersAccessor(MyDbContext db)
        {
            this.db = db;
        }
        public void Create(Employee item)
        {
            db.Employeers.AddAsync(item);
        }
        public IEnumerable<Employee> GetList()
        {
            return db.Employeers.ToArray();
        }
        public Employee Get(int id)
        {
            return db.Employeers.FirstOrDefault(o => o.Id == id);
        }
        public void Update(Employee item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            Employee employee = Get(id);
            if (employee != null)
                db.Employeers.Remove(employee);
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
