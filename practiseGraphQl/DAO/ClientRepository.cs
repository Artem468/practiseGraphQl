using Microsoft.EntityFrameworkCore;
using practiseGraphQl.Models;

namespace practiseGraphQl.DAO
{
    public class ClientRepository : IClientRepository
    {
        private readonly BlogDbContext db;

        public ClientRepository(BlogDbContext db)
        {
            this.db = db;
        }

        public IQueryable<Client> GetClientsOnly()
        {
            return db.Clients.AsQueryable();
        }

        public async Task<Client> AddClient(Client client)
        {
            db.Clients.Add(client);
            await db.SaveChangesAsync();
            return client;
        }

        public Client GetClientById(long id)
        {
            var client = db.Clients.Include(p => p.Waybills).FirstOrDefault(p => p.Id == id);
            if (client != null) return client!;
            return null!;
        }
    }
}