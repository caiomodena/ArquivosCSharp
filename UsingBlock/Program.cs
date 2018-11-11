using System;
using System.IO;

namespace UsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            string path=@"C:\Users\caio\Desktop\Teste.txt";
            
            try{
                using(FileStream fileStream=new FileStream(path,FileMode.Open)){
                    using(StreamReader streamReader=new StreamReader(fileStream)){
                        while(!streamReader.EndOfStream){
                            Console.WriteLine(streamReader.ReadLine());
                        }
                    }

                }
            }
            catch(IOException ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}
