
namespace Proviser3.Core.Model
{
    public class CaseClass : TemplateClass
    {
        [Indexed(Name = "ListingID", Order = 1, Unique = true)]
        public string Case { get; set; }
        public string Header { get; set; }
        public string Note { get; set; }
        public DateTime PrisonDate { get; set; }
        public string CriminalNumber { get; set; }
        public string MainCase { get; set; }
        public string Status { get; set; }
    }
}
