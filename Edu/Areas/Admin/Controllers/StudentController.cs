using Edu.Areas.Admin.ViewModels;
using Edu.DAL;
using Edu.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Edu.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public StudentController(AppDbContext context, IWebHostEnvironment env)
        {
            _env = env;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var res = await _context.Students.Include(m => m.Faculty).ToListAsync();
            return View(res);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return BadRequest();

            var stu = await _context.Students.Where(w => !w.IsDeleted).FirstOrDefaultAsync(m => m.Id == id);
            if (stu == null) return NotFound();

            _context.Remove(stu);

            await _context.SaveChangesAsync();

            return Ok();

        }
        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateStuVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var fileName = ProcessUploadedFile(model);

            var faculty = _context.Faculties.Where(c => !c.IsDeleted).FirstOrDefaultAsync(m => m.Id == model.FacultyId);
            if (faculty==null)
            {
                ModelState.AddModelError("Faculty", "Bele faculty yoxdur!");
                return View(model);

            }
            Student stu = new()
            {
                Name= model.Name,
                Description= model.Description,
                Image=fileName,
                FacultyId=model.FacultyId
            };
            await _context.Students.AddAsync(stu);
             _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        private string ProcessUploadedFile(CreateStuVM model)
        {
            string uniqueFileName = null;

            if (model.Photo != null)
            {
                string uploadsFolder = Path.Combine(_env.WebRootPath, "img");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Photo.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }

    }
}
