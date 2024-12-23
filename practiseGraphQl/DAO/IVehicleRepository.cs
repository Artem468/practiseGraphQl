using practiseGraphQl.Models;

namespace practiseGraphQl.DAO
{
    public interface IVehicleRepository
    {
        IQueryable<Vehicle> GetVehiclesOnly();
        Task<Vehicle> AddVehicle(Vehicle vehicle);
        Vehicle GetVehicleById(long id);
    }
}