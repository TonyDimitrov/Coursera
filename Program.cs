using System;
using System.IO;
using System.Linq;

namespace Coursera
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new InMemoryStore();

            var flatValues = db.GetStudents().Select(s => new StudentDTO
            {
                Name = s.Name,
                CouseNames = s.Courses.Select(c => c.Name).ToList(),
                TotalCredits = s.Courses.Select(c => c.Credit).Sum(),
            });

            var stringCSVFormat = CSVGenerator.GenereteCSV(flatValues);

            IWriter writer = new FileWriter();

            string path = Environment.GetFolderPath(
                         Environment.SpecialFolder.MyDocuments);
            writer.Write(Path.Combine(path, "report.csv"), stringCSVFormat);


        }
    }
}
