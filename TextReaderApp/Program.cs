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
            Console.WriteLine("Choose a file that needs to be read");
            TxtReader.GetTextFromFile(Convert.ToInt32(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
