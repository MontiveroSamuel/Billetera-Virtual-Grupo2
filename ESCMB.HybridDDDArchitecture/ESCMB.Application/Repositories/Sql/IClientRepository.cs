﻿using Common.Application.Repositories.Sql;
using Common.Domain.Entities;
using ESCMB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCMB.Application.Repositories.Sql
{
    public interface IClientRepository : IRepository<Client>
    {
        Task<string> AddOneAsync(Client entity);
    }
}
