using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class MenuItemsReview
    {
        public int MenuItemsReviewId { get; set; }
        public int UserId { get; set; }
        public int RestaurantMenuItemId { get; set; }
        public string Description { get; set; }
        public int? Grade { get; set; }
    }
}
