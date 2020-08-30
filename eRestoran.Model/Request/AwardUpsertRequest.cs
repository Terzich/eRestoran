using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eRestoran.Model.Request
{
    public class AwardUpsertRequest
    {
        [Required]
        public int UserId { get; set; }
        [Required]

        public string Description { get; set; }
        [Required]

        public bool? Active { get; set; }
        [Required]

        public DateTime? AwardDate { get; set; }


    }
}
