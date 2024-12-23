using practiseGraphQl.DAO;
using practiseGraphQl.Models;

namespace practiseGraphQl.Data
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Drivers")]
        public IQueryable<Driver> GetDrivers([Service] IDriverRepository driver) => driver.GetDriversOnly();

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Clients")]
        public IQueryable<Client> GetClients([Service] IClientRepository client) => client.GetClientsOnly();
        
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Vehicles")]
        public IQueryable<Vehicle> GetVehicles([Service] IVehicleRepository vehicle) => vehicle.GetVehiclesOnly();
        
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Waybills")]
        public IQueryable<Waybill> GetWaybills([Service] IWaybillRepository waybills) => waybills.GetWaybillsOnly();
    }
}