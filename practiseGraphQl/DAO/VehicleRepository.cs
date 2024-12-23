using Microsoft.EntityFrameworkCore;
using practiseGraphQl.Models;

namespace practiseGraphQl.DAO
{

    public class VehicleRepository : IVehicleRepository
    {
        private readonly BlogDbContext db;

        public VehicleRepository(BlogDbContext db)
        {
            this.db = db;
        }

        public IQueryable<Vehicle> GetVehiclesOnly()
        {
            return db.Vehicles.AsQueryable();
        }

        public async Task<Vehicle> AddVehicle(Vehicle vehicle)
        {
            db.Vehicles.Add(vehicle);
            await db.SaveChangesAsync();
            return vehicle;
        }
        
        public Vehicle GetVehicleById(long id)
        {
            var vehicle = db.Vehicles.Include(p => p.Waybills).FirstOrDefault(p => p.Id == id);
            if (vehicle != null) return vehicle!;
            return null!;
        }
    }
}