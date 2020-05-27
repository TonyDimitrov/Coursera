using System.IO;
using System.Text;

namespace Coursera
{
    public class FileWriter : IWriter
    {
        public void Write(string path, string content)
        {
            File.WriteAllText(path, content, Encoding.UTF8);
        }
    }
}
