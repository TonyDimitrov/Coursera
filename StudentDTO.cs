using System.Collections.Generic;

namespace Coursera
{
   public class StudentDTO
    {
        public string Name { get; set; }

        public int TotalCredits { get; set; }

        public List<string> CouseNames { get; set; }
    }
}