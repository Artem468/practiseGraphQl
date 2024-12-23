using practiseGraphQl.Models;

namespace practiseGraphQl.DAO
{
    public interface IClientRepository
    {
        IQueryable<Client> GetClientsOnly();
        Task<Client> AddClient(Client client);
        Client GetClientById(long id);
    }
}