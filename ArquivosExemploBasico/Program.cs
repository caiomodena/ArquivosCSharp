using System;
using System.IO;

namespace ArquivosExemploBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath=@"C:\Users\caio\Desktop\Teste.txt";
            string targetPath=@"C:\Users\caio\Desktop\Teste2.txt";
            string[] lines=File.ReadAllLines(sourcePath);
            foreach(string line in lines){
                Console.WriteLine(line);
            }

            try{
                FileInfo fileInfo=new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
            }
            catch(IOException e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
