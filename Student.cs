using System.Collections.Generic;
namespace Coursera
{
    public class Student
    {
        public Student()
        {
            this.Courses = new HashSet<Course>();
        }
        public string Name { get; set; }

        public int TotalCredit { get; set; }

        public HashSet<Course> Courses { get; set; }
    }
}