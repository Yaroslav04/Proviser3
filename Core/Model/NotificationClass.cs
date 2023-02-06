using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proviser3.Core.Model
{
    public class NotificationClass : TemplateClass
    {
        [Indexed(Name = "ListingID", Order = 1, Unique = true)]
        public string Type { get; set; }

        [Indexed(Name = "ListingID", Order = 2, Unique = true)]
        public string Description { get; set; }

        [Indexed(Name = "ListingID", Order = 3, Unique = true)]
        public string Case { get; set; }
        public string Link { get; set; }

        [Indexed(Name = "ListingID", Order = 4, Unique = true)]
        public DateTime Date { get; set; }
        public bool IsShow { get; set; }
    }
}
