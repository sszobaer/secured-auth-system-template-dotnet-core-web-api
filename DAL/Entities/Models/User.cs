using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Models
{
    public class User
    {
        public User()
        {
            UserId = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        [Key, Required]
        public Guid UserId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, EmailAddress, MaxLength(150)]
        public string Email { get; set; }

        [Required, Phone, MaxLength(20)]
        public string PhoneNumber { get; set; }

        [Required, MaxLength(256)]
        public string PasswordHash { get; set; }

        [Required, ForeignKey("Role")]
        public Guid RoleId { get; set; }

        public virtual UserRole Role { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }
    }
}