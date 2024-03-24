using Carter;
using RDP.EDB.Management.WebApi.Endpoints.Authentication.Post;

namespace RDP.EDB.Management.WebApi.Endpoints.People;

public class AuthenticationEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/authentication");
        const string tag = "authentication";

        group.MapPost("", PostAuthenticationEndpoint.HandleAsync)
            .WithTags(tag)
            .WithOpenApi();
    }        
}
