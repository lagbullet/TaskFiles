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
        public FileInfo[] Files;

        public string Dir { get; set; }

        public TextReader(string dir)
        {
            Dir = dir;
        }

        public void GetFilesFromDir()
        {
            DirectoryInfo dir = new DirectoryInfo(Dir);
            Files = dir.GetFiles("*.txt");
        }

        public void ShowFileText(int item)
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
