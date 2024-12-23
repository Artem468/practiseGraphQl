using practiseGraphQl.Models;

namespace practiseGraphQl.DAO
{
    public interface IWaybillRepository
    {
        IQueryable<Waybill> GetWaybillsOnly();
        Task<Waybill> AddWaybill(Waybill waybill);
    }
}