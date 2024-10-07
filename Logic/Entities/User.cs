using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Entities
{
    public class User
    {
        [Key]
        public Guid ID { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        [ForeignKey(nameof(RoleID))]
        public Guid? RoleID { get; set; }
        public Role? Role { get; set; } 
        public string? Password { get; set; } = null!;

    }
}
