using Microsoft.EntityFrameworkCore;
using FinalCourseRegistration.Models;

namespace FinalCourseRegistration.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed with your existing sample data so nothing "disappears" after migrating
            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, FirstName = "Alice", LastName = "Brown", Email = "alice.brown@example.com", PhoneNumber = "123-456-7890" },
                new Student { StudentId = 2, FirstName = "Bob", LastName = "Johnson", Email = "bob.johnson@example.com", PhoneNumber = "987-654-3210" }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course { CourseId = 1, CourseNumber = "CS101", CourseName = "Introduction to Computer Science", Description = "Basic programming concepts" },
                new Course { CourseId = 2, CourseNumber = "MTH102", CourseName = "Calculus I", Description = "Limits, derivatives, and integrals" }
            );
        }
    }
}