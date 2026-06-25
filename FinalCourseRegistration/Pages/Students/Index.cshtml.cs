using FinalCourseRegistration.Data;
using FinalCourseRegistration.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FinalCourseRegistration.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;
        public IndexModel(AppDbContext context) => _context = context;

        public List<Student> Students { get; set; } = new();

        public async Task OnGetAsync()
        {
            Students = await _context.Students.ToListAsync();
        }
    }
}