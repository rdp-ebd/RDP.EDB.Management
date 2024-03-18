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

        group.MapGet("", GetEndpoint.HandleAsync)
            .WithTags(tag)
            .WithOpenApi();

        group.MapGet("{id}", GetByIdEndpoint.HandleAsync)
            .WithTags(tag)
            .WithOpenApi();
    }        
}
