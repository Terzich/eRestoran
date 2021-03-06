﻿using System;
using System.Collections.Generic;

namespace eRestoran.WebAPI.Database
{
    public partial class DiscountType
    {
        public DiscountType()
        {
            Discount = new HashSet<Discount>();
            SuperOffer = new HashSet<SuperOffer>();
        }

        public int DiscountTypeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Discount> Discount { get; set; }
        public virtual ICollection<SuperOffer> SuperOffer { get; set; }
    }
}
