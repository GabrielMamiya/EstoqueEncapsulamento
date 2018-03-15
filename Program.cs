using System;
using System.Globalization;

namespace EstoqueEncapsulamento
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Estoque produto1;

            string nome = Console.ReadLine();
            int estoque = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            produto1 = new Estoque(nome, estoque);

            produto1.imprimeEstoque();




        }
    }
}
