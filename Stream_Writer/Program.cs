using System;
using System.IO;
namespace Stream_Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath=@"C:\Users\caio\Desktop\Teste.txt";
            string targetPath=@"C:\Users\caio\Desktop\Teste1.txt";
            try{
                string[] lines=File.ReadAllLines(sourcePath);
                using(StreamWriter streamWriter=File.AppendText(targetPath)){
                    foreach(string line in lines){
                        streamWriter.WriteLine(line.ToUpper());
                    }
                }

            }
            catch(IOException e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
