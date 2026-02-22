using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BLL.DTOs
{
    public class CreateRoleDTO
    {
        public string RoleName { get; set; } 
    }

    public class ResponseRoleDTO
    {
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }
    }

}
