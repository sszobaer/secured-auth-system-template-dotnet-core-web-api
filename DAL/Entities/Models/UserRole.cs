using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities.Models
{
    public class UserRole
    {
        public UserRole()
        {
            Users = new List<User>();
        }

        [Key, Required]
        public Guid RoleId { get; set; }

        [Required, MaxLength(50)]
        public string RoleName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}