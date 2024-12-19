using practiseGraphQl.Models;

namespace practiseGraphQl.Data
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Driver> GetDrivers([Service] BlogDbContext context) => context.Drivers;

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Client> GetClients([Service] BlogDbContext context) => context.Clients;
        
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Vehicle> GetVehicles([Service] BlogDbContext context) => context.Vehicles;
        
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Waybill> GetWaybills([Service] BlogDbContext context) => context.Waybills;
    }
}