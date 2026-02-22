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

        public List<ResponseRoleDTO> GetAllRole()
        {
            var data = factory.RoleData().GetAllRole();
            var ret = MapperConfig.GetMapper().Map<List<ResponseRoleDTO>>(data);
            if (ret != null)
            {
                return ret;
            }
            else
            {
                throw new Exception("Not Found error");
            }
        }
        public ResponseRoleDTO GetRoleById(Guid RoleId){
            var data = factory.RoleData().GetRole(RoleId);
            var ret = MapperConfig.GetMapper().Map<ResponseRoleDTO>(data);
            if (ret != null) return ret;
            else throw new Exception("Not Found error");
        }
        public UserRole CreateRole(CreateRoleDTO dto)
        {
            var data = MapperConfig.GetMapper().Map<UserRole>(dto);
            return factory.RoleData().CreateRole(data);
        }
        public UserRole UpdateRole(CreateRoleDTO role, Guid RoleId)
        {
            var data = GetRoleById(RoleId);
            if (data == null) throw new Exception("Role Not found");

            var MappedData =  MapperConfig.GetMapper().Map<UserRole>(role);

            return factory.RoleData().UpdateRole(MappedData, RoleId);
        }
    }
}
