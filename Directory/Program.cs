using System;
using System.IO;
using System.Collections.Generic;

namespace DirectoryEstudo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path=@"C:\Users\caio\Desktop\teste";
            try{
                //Listar diretórios
                IEnumerable<string> folder=Directory.EnumerateDirectories(path,"*.*",SearchOption.AllDirectories);
                Console.WriteLine("folders:");
                foreach(string f in folder){
                    Console.WriteLine(f);
                }
                //Listar arquivos
                IEnumerable<string> files=Directory.EnumerateFiles(path,"*.*",SearchOption.AllDirectories);
                Console.WriteLine("files:");
                foreach(string f in files){
                    Console.WriteLine(f);
                }
                //Criação de pasta
                Directory.CreateDirectory(path+"\\newfolder");
            }
            catch(IOException ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}
