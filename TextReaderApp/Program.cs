using System;
using System.IO;

namespace TextReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a directory");
            TextReader TxtReader = new TextReader(Console.ReadLine());
            TxtReader.GetFilesFromDir();
            int i = 0;
            foreach (FileInfo file in TxtReader.Files)
                Console.WriteLine("{0} - {1}", ++i, file.Name);
            Console.WriteLine("Choose a file that needs to be read");
            Console.Write(TxtReader.GetFileText(Convert.ToInt32(Console.ReadLine())));

            Console.ReadKey();
        }
    }
}
