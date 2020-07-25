using System;
using System.Collections.Generic;

namespace eRestoran.WebAPI.Database
{
    public partial class Visit
    {
        public int VisitId { get; set; }
        public int UserId { get; set; }
        public DateTime? DateOfVisit { get; set; }

        public virtual User User { get; set; }
    }
}
