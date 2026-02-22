using DAL.Entities.Context;
using DAL.Entities.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repos
{
    public class RoleRepo : IRole
    {
        protected readonly AuthContext authContext;
        public RoleRepo(AuthContext authContext)
        {
            this.authContext = authContext;
        }

        public virtual List<UserRole> GetAllRole()
        {
            return authContext.UserRoles
                .OrderBy(r => r.RoleName)
                .ToList();
        }
        public virtual UserRole GetRole(Guid RoleId)
        {
            return authContext.UserRoles.Find(RoleId);
        }

        public virtual UserRole CreateRole(UserRole role)
        {
            authContext.UserRoles.Add(role);
            authContext.SaveChanges();
            return role;
        }

        public virtual UserRole UpdateRole(UserRole role, Guid roleId)
        {
            var existingRole = authContext.UserRoles.Find(roleId);
            if (existingRole == null) return null;

           
            existingRole.RoleName = role.RoleName;

            authContext.SaveChanges();
            return existingRole;
        }
        public virtual bool DeleteRole(Guid RoleId)
        {
            var role = authContext.UserRoles.Find(RoleId);
            if (role == null) return false;
            authContext.UserRoles.Remove(role);
            authContext.SaveChanges();
            return true;

        }
    }
}
