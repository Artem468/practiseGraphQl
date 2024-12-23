using practiseGraphQl.Models;

namespace practiseGraphQl.DAO
{
    public class WaybillRepository : IWaybillRepository
    {
        private readonly BlogDbContext db;

        public WaybillRepository(BlogDbContext db)
        {
            this.db = db;
        }

        public IQueryable<Waybill> GetWaybillsOnly()
        {
            return db.Waybills.AsQueryable();
        }

        public async Task<Waybill> AddWaybill(Waybill waybill)
        {
            db.Waybills.Add(waybill);
            await db.SaveChangesAsync();
            return waybill;
        }
    }
}