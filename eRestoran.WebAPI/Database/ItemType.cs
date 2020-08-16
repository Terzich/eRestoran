using System;
using System.Collections.Generic;

namespace eRestoran.WebAPI.Database
{
    public partial class ItemType
    {
        public ItemType()
        {
            Discount = new HashSet<Discount>();
            ItemCategory = new HashSet<ItemCategory>();
            SuperOffer = new HashSet<SuperOffer>();
        }

        public int ItemTypeId { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Discount> Discount { get; set; }
        public virtual ICollection<ItemCategory> ItemCategory { get; set; }
        public virtual ICollection<SuperOffer> SuperOffer { get; set; }
    }
}
