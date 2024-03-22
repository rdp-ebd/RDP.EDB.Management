﻿using RDP.EDB.Management.Application.Abstractions.Result;
using RDP.EDB.Management.Domain.Entities;

namespace RDP.EDB.Management.Application.UseCases.People.Queries.GetById;

public class GetPersonByIdQueryResult(Person? data) : BaseResult<Person?>(data);
