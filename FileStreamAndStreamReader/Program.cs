using System;
using System.IO;

namespace FileStreamAndStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path=@"C:\Users\caio\Desktop\Teste.txt";
            FileStream fileStream=null;
            StreamReader streamReader=null;
            try{
                fileStream=new FileStream(path,FileMode.Open);
                streamReader=new StreamReader(fileStream);
                //poderia utilizar classe File.OpenText para implicitamente instanciar
                //FileStream e StreamReader
                string line=streamReader.ReadLine();
                Console.WriteLine(line);
            }
            catch(IOException ex){
                Console.WriteLine(ex.Message);
            }
            finally{
                if(streamReader!=null){
                    streamReader.Close();
                }
                if(fileStream!=null){
                    fileStream.Close();
                }
            }
            
        }
    }
}
