using System;
using System.IO;
using System.Collections.Generic;
namespace ExercicioArquivos{
    static class ConsoleEscrita{
        static string caminhoOrigem;
        static string caminhoDestino;
        static List<Produto> listaProdutos;

        public static void CaminhoArquivoOrigem(){
            Console.WriteLine("Qual o caminho do arquivo de origem?");
            caminhoOrigem=Console.ReadLine();
        }
        public static void CriacaoNovoDiretorio(){
            string diretorioAtual=Path.GetDirectoryName(caminhoOrigem);  
            caminhoDestino=diretorioAtual+"\\out";   
            
            Directory.CreateDirectory(caminhoDestino);
            caminhoDestino+="\\summary.csv";
            using(File.Create(caminhoDestino));          
            
        }
        public static void EscritaArquivoDestino(List<Produto> lista){
            using(StreamWriter streamWriter=File.AppendText(caminhoDestino)){
                foreach(Produto prod in lista){
                    streamWriter.WriteLine(prod.ToString());
                }
            }
        }
        public static List<Produto> LeituraArquivoOrigem(){
            listaProdutos=new List<Produto>();
            string linhaArquivo;
            using(FileStream fileStream=new FileStream(caminhoOrigem,FileMode.Open)){
                using(StreamReader streamReader=new StreamReader(fileStream)){
                while(!streamReader.EndOfStream){
                    linhaArquivo=streamReader.ReadLine();
                    string nomeProduto=linhaArquivo.Substring(0,linhaArquivo.IndexOf(","));
                    double precoProduto=Double.Parse(linhaArquivo.Substring(linhaArquivo.IndexOf(",")+1,
                        linhaArquivo.LastIndexOf(",")-(linhaArquivo.IndexOf(",")+1)));
                    int quantidadeEstoque=int.Parse(linhaArquivo.Substring(linhaArquivo.LastIndexOf(",")+1,
                        linhaArquivo.Length-(linhaArquivo.LastIndexOf(",")+1)));
                    Produto produto=new Produto(nomeProduto,precoProduto,quantidadeEstoque);
                    listaProdutos.Add(produto);
                    }
                }   
            }
            return listaProdutos;
        }
    }
}