using FinalCourseRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalCourseRegistration.Pages.Courses
{
    public class IndexModel : PageModel
    {
        public List<Course> Courses { get; set; }
        public void OnGet()
        {
            Courses = new List<Course>
            {
                new Course { CourseId = 1, CourseNumber = "CS101", CourseName = "Introduction to Computer Science", Description = "Basic programming concepts" },
                new Course { CourseId = 2, CourseNumber = "MTH102", CourseName = "Calculus I", Description = "Limits, derivatives, and integrals" }
            };
        }
    }
}
