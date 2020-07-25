using System;
using System.Collections.Generic;

namespace eRestoran.WebAPI.Database
{
    public partial class RecommendationType
    {
        public RecommendationType()
        {
            VisitorRecommendation = new HashSet<VisitorRecommendation>();
        }

        public int RecommendationTypeId { get; set; }
        public string RecommendationTypeDescription { get; set; }

        public virtual ICollection<VisitorRecommendation> VisitorRecommendation { get; set; }
    }
}
