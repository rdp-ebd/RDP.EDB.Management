using AutoMapper;
using RDP.EDB.Management.Domain.Entities;
using RDP.EDB.Management.WebApi.Endpoints.People.GetById;

namespace RDP.EDB.Management.WebApi.MapperProfiles.People;

public class GetPeopleByIdProfile : Profile
{
    public GetPeopleByIdProfile()
    {
        CreateMap<Person, GetPersonByIdResponse>()
            .ConstructUsing(person => new GetPersonByIdResponse(
                person.FirstName,
                person.Surname
            ));
    }
}
