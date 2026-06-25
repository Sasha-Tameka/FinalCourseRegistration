namespace FinalCourseRegistration.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseNumber { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}