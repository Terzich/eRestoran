using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model.Request
{
    public class AwardUpsertRequest
    {
        public int UserId { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }
        public DateTime? AwardDate { get; set; }


    }
}
