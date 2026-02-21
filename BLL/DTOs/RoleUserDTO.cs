using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class RoleUserDTO
    {
        public virtual List<UserDTO> Users { get; set; }
        public RoleUserDTO() 
        { 
            Users = new List<UserDTO>();
        }
    }
}
