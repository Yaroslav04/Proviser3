
namespace Proviser3.Core.Model
{
    public class TemplateClass
    {
        [AutoIncrement]
        [PrimaryKey]
        [NotNull]
        public int N { get; set; }
        public DateTime SaveDate { get; set; }
    }
}
