using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public ICollection<UserRole> UserRole { get; set; }
    }
}
