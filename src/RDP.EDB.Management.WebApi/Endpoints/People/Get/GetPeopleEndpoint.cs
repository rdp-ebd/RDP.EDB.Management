﻿using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RDP.EDB.Management.Application.UseCases.People.Queries.Get;

namespace RDP.EDB.Management.WebApi.Endpoints.People.Get;

public class GetPeopleEndpoint
{
    public static async Task<Ok<IEnumerable<GetPeopleResponse>>> HandleAsync(
        [FromServices] ISender sender,
        [FromServices] IMapper mapper,
        CancellationToken token
    )
    {
        var result = await sender.Send(new GetPeopleQuery(), token);
        var people = mapper.Map<IEnumerable<GetPeopleResponse>>(result?.Data);

        return TypedResults.Ok(people);
    }
}