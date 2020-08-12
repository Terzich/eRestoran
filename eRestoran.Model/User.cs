using System;
using System.Collections.Generic;
using System.Text;


namespace eRestoran.Model
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }
        public string Username { get; set; }
        public ICollection<UserRole> UserRole { get; set; }



    }
}
