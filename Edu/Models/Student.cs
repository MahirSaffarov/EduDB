using Edu.Models.Common;

namespace Edu.Models
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }
    }
}
