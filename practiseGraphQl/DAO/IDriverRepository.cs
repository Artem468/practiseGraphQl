using practiseGraphQl.Models;

namespace practiseGraphQl.DAO
{
    public interface IDriverRepository
    {
        IQueryable<Driver> GetDriversOnly();
        Task<Driver> AddDriver(Driver driver);
        Driver GetDriverById(long id);
    }
}