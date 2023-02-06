﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proviser3.Core.Model
{
    public class DecisionClass : TemplateClass
    {
        [Indexed(Name = "ListingID", Order = 1, Unique = true)]
        public string Id { get; set; }
        public string DecisionType { get; set; }
        public DateTime DecisionDate { get; set; }
        public DateTime LegalDate { get; set; }
        public string JudiciaryType { get; set; }
        public string Case { get; set; }
        public string Court { get; set; }
        public string Judge { get; set; }
        public string URL { get; set; }
        public string Content { get; set; }
        public string CriminalNumber { get; set; }
        public string Category { get; set; }
    }
}
