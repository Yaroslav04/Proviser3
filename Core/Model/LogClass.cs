using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proviser3.Core.Model
{
    public class LogClass : TemplateClass
    {
        public string Case { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public string Result { get; set; }
    }
}
