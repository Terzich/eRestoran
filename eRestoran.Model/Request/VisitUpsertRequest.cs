using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model.Request
{
    public class VisitUpsertRequest
    {
        public int UserId { get; set; }
        public DateTime? DateOfVisit { get; set; }
    }
}
