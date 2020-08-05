﻿using System;
using System.Collections.Generic;

namespace eRestoran.WebAPI.Database
{
    public partial class RestaurantMenuItem
    {
        public RestaurantMenuItem()
        {
            MenuItemsReview = new HashSet<MenuItemsReview>();
            SuperOffer = new HashSet<SuperOffer>();
        }

        public int RestaurantMenuItemId { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public int ItemCategoryId { get; set; }

        public virtual ItemCategory ItemCategory { get; set; }
        public virtual ICollection<MenuItemsReview> MenuItemsReview { get; set; }
        public virtual ICollection<SuperOffer> SuperOffer { get; set; }
    }
}
