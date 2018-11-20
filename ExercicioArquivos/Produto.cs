using System;
namespace ExercicioArquivos{
    class Produto{
        string nome;
        double preco;
        int quantidadeEstoque;
        public Produto(string nome,double preco,int quantidadeEstoque){
            this.nome=nome;
            this.preco=preco;
            this.quantidadeEstoque=quantidadeEstoque;
        }
        public override string ToString(){
            return nome+","+preco*quantidadeEstoque;
        }
    }
}