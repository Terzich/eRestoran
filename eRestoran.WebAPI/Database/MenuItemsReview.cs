using System;
using System.Collections.Generic;

namespace eRestoran.WebAPI.Database
{
    public partial class MenuItemsReview
    {
        public int MenuItemsReviewId { get; set; }
        public int UserId { get; set; }
        public int RestaurantMenuItemId { get; set; }
        public string Description { get; set; }
        public int? Grade { get; set; }

        public virtual RestaurantMenuItem RestaurantMenuItem { get; set; }
        public virtual User User { get; set; }
    }
}
