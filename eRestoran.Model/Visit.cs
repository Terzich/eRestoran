using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class Visit
    {
        public int VisitId { get; set; }
        public int UserId { get; set; }
        public DateTime? DateOfVisit { get; set; }
    }
}
