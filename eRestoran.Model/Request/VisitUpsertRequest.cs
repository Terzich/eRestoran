using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eRestoran.Model.Request
{
    public class VisitUpsertRequest
    {
        [Required]

        public int UserId { get; set; }
        [Required]

        public DateTime? DateOfVisit { get; set; }
    }
}
