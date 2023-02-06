﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proviser3.Core.Model
{
    public class StanClass : TemplateClass
    {
        [Indexed(Name = "ListingID", Order = 1, Unique = true)]
        public string Court { get; set; }
        [Indexed(Name = "ListingID", Order = 2, Unique = true)]
        public string Case { get; set; }
        [Indexed(Name = "ListingID", Order = 3, Unique = true)]
        public string SubCase { get; set; }
        [Indexed(Name = "ListingID", Order = 4, Unique = true)]
        public DateTime RegDate { get; set; }
        [Indexed(Name = "ListingID", Order = 5, Unique = true)]
        public string Judge { get; set; }
        [Indexed(Name = "ListingID", Order = 6, Unique = true)]
        public string SubJudge { get; set; }
        [Indexed(Name = "ListingID", Order = 7, Unique = true)]
        public string Littigans { get; set; }
        [Indexed(Name = "ListingID", Order = 8, Unique = true)]
        public DateTime Date { get; set; }
        [Indexed(Name = "ListingID", Order = 9, Unique = true)]
        public string Decision { get; set; }
        [Indexed(Name = "ListingID", Order = 10, Unique = true)]
        public string SubDecision { get; set; }
        [Indexed(Name = "ListingID", Order = 11, Unique = true)]
        public string Category { get; set; }
        [Indexed(Name = "ListingID", Order = 12, Unique = true)]
        public string Description { get; set; }
    }
}
