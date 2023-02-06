using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proviser3.Core.Model
{
    public class WitnessClass : TemplateClass 
    {
        [Indexed(Name = "ListingID", Order = 1, Unique = true)]
        public string Case { get; set; }
        public string Type { get; set; }
        [Indexed(Name = "ListingID", Order = 2, Unique = true)]
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public string Location { get; set; }
        public string Work { get; set; }
        public string Contact { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
