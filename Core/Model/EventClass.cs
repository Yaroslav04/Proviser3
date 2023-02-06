using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proviser3.Core.Model
{
    public class EventClass : TemplateClass
    {
        public string Case { get; set; }
        public DateTime Date { get; set; }
        public string Event { get; set; }
        public string Description { get; set; }
    }
}
