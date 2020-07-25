using System;
using System.Collections.Generic;

namespace eRestoran.WebAPI.Database
{
    public partial class ItemType
    {
        public ItemType()
        {
            ItemCategory = new HashSet<ItemCategory>();
        }

        public int ItemTypeId { get; set; }
        public string Type { get; set; }

        public virtual ICollection<ItemCategory> ItemCategory { get; set; }
    }
}
