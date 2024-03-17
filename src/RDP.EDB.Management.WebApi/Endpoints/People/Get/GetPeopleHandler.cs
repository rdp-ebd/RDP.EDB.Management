using Microsoft.AspNetCore.Http.HttpResults;

namespace RDP.EDB.Management.WebApi.Endpoints.People.Get;

public class GetPeopleHandler
{
    public static async Task<Ok<IEnumerable<GetPeopleResponse>>> HandleAsync(
        CancellationToken token
    )
    {
        var peopleResponse = new List<GetPeopleResponse>
        {
            new("diego", "doná"),
            new("sandro", "ribeiro"),
            new("shuda", "shudeira"),
            new("maicon", "xD"),
            new("livia", "olivia"),
        };

        return TypedResults.Ok(peopleResponse.AsEnumerable());
    }
}
