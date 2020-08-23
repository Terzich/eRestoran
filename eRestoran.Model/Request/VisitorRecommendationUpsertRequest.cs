using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model.Request
{
    public class VisitorRecommendationUpsertRequest
    {
        public int UserId { get; set; }
        public string RecommendationDescription { get; set; }
    }
}
