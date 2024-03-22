using Carter;
using RDP.EDB.Management.WebApi.Endpoints.People.Get;
using RDP.EDB.Management.WebApi.Endpoints.People.GetById;
using RDP.EDB.Management.WebApi.Endpoints.People.Post;

namespace RDP.EDB.Management.WebApi.Endpoints.People;

public class PeopleEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/people");
        const string tag = "people";

        group.MapGet("", GetPeopleEndpoint.HandleAsync)
            .WithTags(tag)
            .WithOpenApi();

        group.MapGet("{id}", GetPersonByIdEndpoint.HandleAsync)
            .WithTags(tag)
            .WithOpenApi();

        group.MapPost("", PostPersonEndpoint.HandleAsync)
            .WithTags(tag)
            .WithOpenApi();
    }        
}
