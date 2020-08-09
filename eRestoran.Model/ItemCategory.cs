using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class ItemCategory
    {
        public int ItemCategoryId { get; set; }
        public string Category { get; set; }
        public int ItemTypeId { get; set; }
    }
}
