using FinalCourseRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalCourseRegistration.Pages.Students
{
    public class IndexModel : PageModel
    {
        public List<Student> Students { get; set; }
        public void OnGet()
        {
            Students = new List<Student>
            {
                new Student { StudentId = 1, FirstName = "Alice", LastName = "Brown", Email = "alice.brown@example.com", PhoneNumber = "123-456-7890" },
                new Student { StudentId = 2, FirstName = "Bob", LastName = "Johnson", Email = "bob.johnson@example.com", PhoneNumber = "987-654-3210" }
            };
        }
    }
}
