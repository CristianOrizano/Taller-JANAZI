using Jazani.Taller.Domain.Admins.Models;
using Jazani.Taller.Domain.Cores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Domain.Admins.Repositories
{
    public interface IPermissionRepository: ICrudRepository<Permission,int>
    {


    }
}
