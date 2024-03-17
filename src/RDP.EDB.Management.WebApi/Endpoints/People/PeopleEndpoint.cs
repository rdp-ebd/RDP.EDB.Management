using Carter;
using RDP.EDB.Management.WebApi.Endpoints.People.Get;
using RDP.EDB.Management.WebApi.Endpoints.People.GetById;

namespace RDP.EDB.Management.WebApi.Endpoints.People;

public class PeopleEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/people");
        const string tag = "people";

        // 1) podemos abstrair controllers usando "handlers" com métodos static (acho preferível)
        group.MapGet("", GetPeopleHandler.HandleAsync)
            .WithTags(tag)
            .WithOpenApi();

        group.MapGet("{id}", GetPersonByIdHandler.HandleAsync)
            .WithTags(tag)
            .WithOpenApi();
    }        
}
