using BLL.DTOs;
using DAL;
using DAL.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class UserRoleService
    {
        DataAccessFactory factory;

        public UserRoleService(DataAccessFactory _factory)
        {
            factory = _factory;
        }

        public List<RoleDTO> GetAllRole()
        {
            var data = factory.RoleData().GetAllRole();
            var ret = MapperConfig.GetMapper().Map<List<RoleDTO>>(data);
            if (ret != null)
            {
                return ret;
            }
            else
            {
                throw new Exception("Not Found error");
            }
        }

        public UserRole CreateRole(RoleDTO dto)
        {
            var data = MapperConfig.GetMapper().Map<UserRole>(dto);
            return factory.RoleData().CreateRole(data);
        }
    }
}
