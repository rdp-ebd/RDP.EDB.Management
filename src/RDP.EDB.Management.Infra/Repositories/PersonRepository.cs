using Microsoft.EntityFrameworkCore;
using RDP.EDB.Management.Domain.Entities;
using RDP.EDB.Management.Domain.Repositories;
using RDP.EDB.Management.Infra.Contexts;

namespace RDP.EDB.Management.Infra.Repositories;

public class PersonRepository : IPersonRepository
{
    private readonly ApplicationDbContext _context;
    private readonly DbSet<Person> _set;

    public PersonRepository(ApplicationDbContext context)
    {
        _context = context;
        _set = _context.Set<Person>();
    }

    public async Task<List<Person>> GetAll() =>
        await _set.ToListAsync();
}
