using RDP.EDB.Management.Domain.Entities;
using RDP.EDB.Management.Domain.Repositories;
using RDP.EDB.Management.Infra.Contexts;
using RDP.EDB.Management.Infra.Repositories.Abstractions;

namespace RDP.EDB.Management.Infra.Repositories;

public class PersonRepository : BaseRepository<Person>, IPersonRepository
{
    public PersonRepository(ApplicationDbContext context) : base(context)
    {
    }
}
