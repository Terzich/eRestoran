using System;
using System.Collections.Generic;

namespace eRestoran.WebAPI.Database
{
    public partial class Award
    {
        public int AwardId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }
        public DateTime? AwardDate { get; set; }

        public virtual User User { get; set; }
    }
}
