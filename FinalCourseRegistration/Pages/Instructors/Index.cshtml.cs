using FinalCourseRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalCourseRegistration.Pages.Instructors
{
    public class IndexModel : PageModel
    {
        public List<Instructor> Instructors { get; set; }
        public void OnGet()
        {
            Instructors = new List<Instructor>
            {
                new Instructor { InstructorId = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Course = "Math 101" },
                new Instructor { InstructorId = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", Course = "Physics 102" }
            };
        }
    }
}
