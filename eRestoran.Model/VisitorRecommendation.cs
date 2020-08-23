using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class VisitorRecommendation
    {
        public int VisitorRecommendationId { get; set; }
        public int UserId { get; set; }
        public string RecommendationDescription { get; set; }
    }
}
