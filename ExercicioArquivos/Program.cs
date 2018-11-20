using System;
using System.IO;
using System.Collections.Generic;
namespace ExercicioArquivos
{
    class Program
    {
        static void Main(string[] args)
        {    
             
            ConsoleEscrita.CaminhoArquivoOrigem();
            List<Produto> listaProduto = ConsoleEscrita.LeituraArquivoOrigem();
            ConsoleEscrita.CriacaoNovoDiretorio();
            ConsoleEscrita.EscritaArquivoDestino(listaProduto);
            /*string teste="nome produto,1500,4";
            Console.WriteLine(teste.IndexOf(","));
            Console.WriteLine(teste.LastIndexOf(","));
            Console.WriteLine(teste.Length);
            Console.WriteLine(teste.Substring(0,teste.IndexOf(",")));
            Console.WriteLine(teste.Substring(teste.IndexOf(",")+1,
                        teste.LastIndexOf(",")-(teste.IndexOf(",")+1)));
             */
            /*
            string nomeProduto=linhaArquivo.Substring(0,teste.IndexOf(","));
                    double precoProduto=Double.Parse(teste.Substring(teste.IndexOf(","),
                        teste.LastIndexOf(",")));
                    int quantidadeEstoque=int.Parse(teste.Substring(teste.LastIndexOf(","),
                        teste.Length));
             */
        }
    }
}
