using Microsoft.EntityFrameworkCore;
using practiseGraphQl.Models;

namespace practiseGraphQl.DAO
{
    public class DriverRepository : IDriverRepository
    {
        private readonly BlogDbContext db;

        public DriverRepository(BlogDbContext db)
        {
            this.db = db;
        }

        public IQueryable<Driver> GetDriversOnly()
        {
            return db.Drivers.AsQueryable();
        }

        public async Task<Driver> AddDriver(Driver driver)
        {
            db.Drivers.Add(driver);
            await db.SaveChangesAsync();
            return driver;
        }
        
        public Driver GetDriverById(long id)
        {
            var driver = db.Drivers.Include(p => p.Waybills).FirstOrDefault(p => p.Id == id);
            if (driver != null) return driver!;
            return null!;
        }
    }
}