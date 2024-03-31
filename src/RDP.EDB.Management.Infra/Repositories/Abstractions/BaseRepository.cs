using Microsoft.EntityFrameworkCore;
using RDP.EDB.Management.Domain.Repositories.Abstractions;
using RDP.EDB.Management.Infra.Contexts;

namespace RDP.EDB.Management.Infra.Repositories.Abstractions;

public abstract class BaseRepository<T> 
    : IBaseRepository<T> where T : class
{
    protected DbSet<T> _Set;

    protected BaseRepository(ApplicationDbContext context)
    {
        _Set = context.Set<T>();
    }

    public async Task<List<T>> GetAllAsync() =>
        await _Set.ToListAsync();
}
