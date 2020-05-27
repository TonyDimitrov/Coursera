using System;
using System.Collections.Generic;
using System.Text;

namespace Coursera
{
    public static class CSVGenerator
    {
        public static string GenereteCSV(IEnumerable<StudentDTO> students)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var student in students)
            {
                if (string.IsNullOrWhiteSpace(student.Name))
                {
                    throw new ArgumentException("Student name is invalid");
                }

                if (student.CouseNames.Count == 0)
                {
                    sb.Append($"{student.Name}, {student.TotalCredits}{Environment.NewLine}");
                }

                foreach (var course in student.CouseNames)
                {
                    if (string.IsNullOrWhiteSpace(course))
                    {
                        throw new ArgumentException("Course name is invalid");
                    }

                    sb.Append($"{student.Name}, {student.TotalCredits}, {course}{Environment.NewLine}");
                }
            }

            return sb.ToString();
        }
    }
}

//The report should contain the names of the students, the total credit they got for the period and the courses they finished successfully.