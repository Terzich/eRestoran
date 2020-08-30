using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eRestoran.Model.Request
{
    public class VisitorRecommendationUpsertRequest
    {
        [Required]

        public int UserId { get; set; }
        [Required]

        public string RecommendationDescription { get; set; }
    }
}
