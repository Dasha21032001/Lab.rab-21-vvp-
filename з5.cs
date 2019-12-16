using System;
using System.IO;
namespace з5
{
    class Program
    {
        static void Main(string[] args)
        {
            string imy = "C:\\labaratornaynomer21zadanie5.txt";
            Console.WriteLine(Path.GetFileNameWithoutExtension(imy));
        }
    }
}
