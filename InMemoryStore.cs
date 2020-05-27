using System.Collections.Generic;

namespace Coursera
{
    public class InMemoryStore
    {
        public IEnumerable<Student> GetStudents()
        {
            return new List<Student>
            {
            new Student
            {
                Name = "N'Neno",
                Courses = new HashSet<Course>
                {
                   new Course
                   {
                       Name = "HTML",
                       Credit = 2,
                       InstructorName = "Martin",
                       TotalTime = 45,
                   }
                },
            },
            new Student
            {
                Name = "N'Veso",
                Courses = new HashSet<Course>
                {
                   new Course
                   {
                       Name = "CSS",
                       Credit = 3,
                       InstructorName = "Gosho",
                       TotalTime = 60,
                   }
                }
            },
                new Student
            {
                Name = "N'Rosen",
                Courses = new HashSet<Course>
                {
                   new Course
                   {
                       Name = "JS",
                       Credit = 6,
                       InstructorName = "Gosho",
                       TotalTime = 60,
                   },
                   new Course
                   {
                       Name = "CSS",
                       Credit = 3,
                       InstructorName = "Gosho",
                       TotalTime = 60,
                   },
                        new Course
                   {
                       Name = "HTML",
                       Credit = 2,
                       InstructorName = "Martin",
                       TotalTime = 45,
                   }
                }
            }
           };
        }
    }
}
