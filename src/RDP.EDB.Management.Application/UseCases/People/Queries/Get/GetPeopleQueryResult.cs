using RDP.EDB.Management.Application.Abstractions.Result;
using RDP.EDB.Management.Domain.Entities;

namespace RDP.EDB.Management.Application.UseCases.People.Queries.Get;

public class GetPeopleQueryResult(IEnumerable<Person> result) : BaseListResult<Person>(result);
