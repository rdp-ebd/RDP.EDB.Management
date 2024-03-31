namespace RDP.EDB.Management.Domain.Repositories.Abstractions;

public interface IBaseRepository<T> where T : class
{
    Task<List<T>> GetAllAsync();
}
