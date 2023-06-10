using Edu.Models.Common;

namespace Edu.Models
{
    public class Faculty : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
