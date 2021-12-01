﻿using Zamin.Core.Contracts.Data.Commands;
using Zamin.MiniBlog.Core.Domain.People.Entities;

namespace Zamin.MiniBlog.Core.Domain.People.Repositories
{
    public interface IPersonCommandRepository : ICommandRepository<Person>
    {
    }
}