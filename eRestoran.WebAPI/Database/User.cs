using System;
using System.Collections.Generic;

namespace eRestoran.WebAPI.Database
{
    public partial class User
    {
        public User()
        {
            Award = new HashSet<Award>();
            MenuItemsReview = new HashSet<MenuItemsReview>();
            RestaurantReview = new HashSet<RestaurantReview>();
            UserRole = new HashSet<UserRole>();
            Visit = new HashSet<Visit>();
            VisitorRecommendation = new HashSet<VisitorRecommendation>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int CityId { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int GenderId { get; set; }
        public string Username { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }

        public virtual City City { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual ICollection<Award> Award { get; set; }
        public virtual ICollection<MenuItemsReview> MenuItemsReview { get; set; }
        public virtual ICollection<RestaurantReview> RestaurantReview { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }
        public virtual ICollection<Visit> Visit { get; set; }
        public virtual ICollection<VisitorRecommendation> VisitorRecommendation { get; set; }
    }
}
