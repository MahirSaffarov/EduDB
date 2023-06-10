using Edu.Models;
using System.ComponentModel.DataAnnotations;

namespace Edu.Areas.Admin.ViewModels
{
    public class CreateStuVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public IFormFile Photo { get; set; }
        [Required]
        public int FacultyId { get; set; }
    
    }
}
