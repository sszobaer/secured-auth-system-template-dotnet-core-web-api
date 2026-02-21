using DAL.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IRole
    {
        List<UserRole> GetAllRole();
        UserRole GetRole(Guid RoleId);
       UserRole CreateRole(UserRole role);
        UserRole UpdateRole(UserRole role, Guid RoleId);
        bool DeleteRole(Guid RoleId);
    }
}
