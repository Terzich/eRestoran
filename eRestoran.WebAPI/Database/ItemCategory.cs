using System;
using System.Collections.Generic;

namespace eRestoran.WebAPI.Database
{
    public partial class ItemCategory
    {
        public ItemCategory()
        {
            RestaurantMenuItem = new HashSet<RestaurantMenuItem>();
            SuperOffer = new HashSet<SuperOffer>();
        }

        public int ItemCategoryId { get; set; }
        public string Category { get; set; }
        public int ItemTypeId { get; set; }

        public virtual ItemType ItemType { get; set; }
        public virtual ICollection<RestaurantMenuItem> RestaurantMenuItem { get; set; }
        public virtual ICollection<SuperOffer> SuperOffer { get; set; }
    }
}
