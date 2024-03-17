using Carter;
using Microsoft.AspNetCore.Http.HttpResults;

namespace RDP.EDB.Management.WebApi.Endpoints.Other;

public class OtherEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/other");
        const string tag = "other";

        // 2) podemos resolver tudo com lambdas (não acho tão interessante, mesmo usando o mediatr,
        //                                       esse arquivo de rotas vai ficar um pouco poluído)
        group.MapGet("", async Task<Ok<IEnumerable<string>>> (CancellationToken cancellationToken) =>
        {
            return TypedResults.Ok(new string[] { "asd", "asdasd" }.AsEnumerable());
        }).WithTags(tag);

        group.MapGet("{id}", async Task<Results<Ok<string>, NotFound>> (int id, CancellationToken cancellationToken) =>
        {
            if (id == 1)
                return TypedResults.Ok($"found {id}");

            return TypedResults.NotFound();
        }).WithTags(tag);
    }
}
