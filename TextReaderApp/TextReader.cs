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

        public string GetFileText(int item)
        {
            string str = "";
            StreamReader reader = new StreamReader(Files[--item].FullName);
            string line = reader.ReadLine();
            while (line != null)
            {
                str += line + "\n";
                line = reader.ReadLine();
            }
            reader.Close();
            return str;
        }
    }
}
