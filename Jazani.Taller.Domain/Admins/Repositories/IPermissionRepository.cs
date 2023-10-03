﻿using Jazani.Taller.Domain.Admins.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Domain.Admins.Repositories
{
    public interface IPermissionRepository
    {
        Task<IReadOnlyList<Permission>> FindAllAsync();
        Task<Permission> FindByIdAsync(int id);
        Task<Permission> SaveAsync(Permission permission);

    }
}
