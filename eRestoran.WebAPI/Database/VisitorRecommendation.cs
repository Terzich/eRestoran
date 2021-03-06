﻿using System;
using System.Collections.Generic;

namespace eRestoran.WebAPI.Database
{
    public partial class VisitorRecommendation
    {
        public int VisitorRecommendationId { get; set; }
        public int UserId { get; set; }
        public string RecommendationDescription { get; set; }

        public virtual User User { get; set; }
    }
}
