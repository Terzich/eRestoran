using System;
using System.Collections.Generic;

namespace eRestoran.WebAPI.Database
{
    public partial class City
    {
        public City()
        {
            Restaurant = new HashSet<Restaurant>();
            User = new HashSet<User>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }

        public virtual ICollection<Restaurant> Restaurant { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
