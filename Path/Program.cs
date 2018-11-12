using System;
using System.IO;

namespace PathEstudo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path=@"C:\Users\caio\Desktop\teste\teste1.txt";
            Console.WriteLine(Path.DirectorySeparatorChar);
            Console.WriteLine(Path.PathSeparator);
            Console.WriteLine(Path.GetDirectoryName(path));
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetExtension(path));


        }
    }
}
