using System;
using System.Collections.Generic;

namespace eRestoran.WebAPI.Database
{
    public partial class Gender
    {
        public Gender()
        {
            User = new HashSet<User>();
        }

        public int GenderId { get; set; }
        public string Gender1 { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
