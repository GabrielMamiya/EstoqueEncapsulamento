using System;
namespace EstoqueEncapsulamento
{
    public class Estoque
    {

        public string nome { get; private set; }
        public int estoque { get; private set; }

        //constructor
        public Estoque(string nome, int estoque)
        {
            this.nome = nome;
            this.estoque = estoque;
        }

        public void imprimeEstoque(){
            Console.WriteLine("Produto: " + nome);
            Console.WriteLine("Valor no estoque: " + estoque);
        }


    }
}
