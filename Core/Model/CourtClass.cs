using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proviser3.Core.Model
{
    public class CourtClass : TemplateClass
    {
        [Indexed(Name = "ListingID", Order = 1, Unique = true)]
        public DateTime Date { get; set; }
        public string Judge { get; set; }

        [Indexed(Name = "ListingID", Order = 2, Unique = true)]
        public string Case { get; set; }
        public string Court { get; set; }
        public string Littigans { get; set; }
        public string Category { get; set; }
        public string Origin { get; set; }

    }
}
