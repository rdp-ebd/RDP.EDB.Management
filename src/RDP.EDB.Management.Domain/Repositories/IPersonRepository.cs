using RDP.EDB.Management.Domain.Entities;

namespace RDP.EDB.Management.Domain.Repositories;

public interface IPersonRepository
{
    Task<List<Person>> GetAll();
}
