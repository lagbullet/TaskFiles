using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextReaderApp
{
    class TextReader
    {
        private string _Dir;
        private FileInfo[] Files;

        public string Dir { get; set; }

        public TextReader(string dir)
        {
            Dir = dir;
        }

        public void GetFilesFromDir()
        {
            DirectoryInfo dir = new DirectoryInfo(Dir);
            Files = dir.GetFiles("*.txt");
            int i=0;
            foreach (FileInfo file in Files)
                Console.WriteLine("{0} - {1}", ++i, file.Name);
        }

        public void GetTextFromFile(int item)
        {
            StreamReader reader = new StreamReader(Files[--item].FullName);
            string line = reader.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = reader.ReadLine();
            }
            reader.Close();
        }
    }
}
