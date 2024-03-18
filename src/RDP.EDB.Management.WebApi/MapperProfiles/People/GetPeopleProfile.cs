using AutoMapper;
using RDP.EDB.Management.Domain.Entities;
using RDP.EDB.Management.WebApi.Endpoints.People.Get;

namespace RDP.EDB.Management.WebApi.MapperProfiles.People;

public class GetPeopleProfile : Profile
{
    public GetPeopleProfile()
    {
        CreateMap<Person, GetResponse>()
            .ConstructUsing(person => new GetResponse(
                person.FirstName,
                person.Surname
            ));
    }
}
