using System;
using System.IO;

namespace TextReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            string dir;
            Console.WriteLine("Enter a directory");
            dir = Console.ReadLine();
            DirectoryInfo d = new DirectoryInfo(dir);
            FileInfo[] Files = d.GetFiles("*.txt");
            Console.WriteLine("Choose a file that needs to be read");
            foreach (FileInfo file in Files)
                Console.WriteLine("{0} - {1}", ++i, file.Name);
            i=Convert.ToInt32(Console.ReadLine());
            StreamReader reader = new StreamReader(Files[--i].FullName);
            string line = reader.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = reader.ReadLine();
            }
            reader.Close();
            Console.ReadKey();
        }
    }
}
