using System;
using System.Collections.Generic;
using System.Text;


namespace eRestoran.Model
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }


    }
}
