using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class Visitor
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public string Username { get; set; }
        public int NumberOfVisits { get; set; }

    }
}
