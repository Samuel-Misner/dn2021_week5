using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DatabaseConsole
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
    }

    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
    }

    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESSGC;Database=efconsole1;User Id=sa;Password=abc123;");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using (SchoolContext context = new SchoolContext())
            {
                //Student st = new Student() { Name = entry };
                //context.Students.Add(st);
                //context.SaveChanges();

                Student st = new Student() { StudentID = 3 };
                context.Students.Remove(st);
                context.SaveChanges();
            }
        }
    }
}
