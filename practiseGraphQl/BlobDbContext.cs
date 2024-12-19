using Microsoft.EntityFrameworkCore;
using practiseGraphQl.Models;

namespace practiseGraphQl
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions options) : base(options){}

        public DbSet<Client> Clients { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Waybill> Waybills { get; set; }
        public DbSet<Driver> Drivers { get; set; }
    }
}