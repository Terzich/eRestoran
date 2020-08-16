using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class Award
    {
        public int AwardId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }
        public DateTime? AwardDate { get; set; }
        public string VisitorName { get; set; }
    }
}
