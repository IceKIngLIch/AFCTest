using Microsoft.EntityFrameworkCore;
using AFC.Repository.Models;

namespace AFC.Repository
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employeers { get; set; }

        public DbSet<Hall> Halls { get; set; }
        public DbSet<Schedule> Schedulers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }





    }
}