using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class UserDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public Guid RoleId { get; set; }
    }
}
