using System;
using System.Collections.Generic;

namespace eRestoran.WebAPI.Database
{
    public partial class RestaurantMenuItem
    {
        public RestaurantMenuItem()
        {
            Discount = new HashSet<Discount>();
            MenuItemsReview = new HashSet<MenuItemsReview>();
            SuperOffer = new HashSet<SuperOffer>();
        }

        public int RestaurantMenuItemId { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public int ItemCategoryId { get; set; }
        public int? QuantityId { get; set; }
        public byte[] Image { get; set; }

        public virtual ItemCategory ItemCategory { get; set; }
        public virtual Quantity Quantity { get; set; }
        public virtual ICollection<Discount> Discount { get; set; }
        public virtual ICollection<MenuItemsReview> MenuItemsReview { get; set; }
        public virtual ICollection<SuperOffer> SuperOffer { get; set; }
    }
}
