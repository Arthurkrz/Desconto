using System;

namespace Desconto
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados dados = new Dados();
            bool controle = true;
            while (controle)
            {
                Console.WriteLine("Insira o nome do produto: ");
                dados.nome = Console.ReadLine();
                Console.WriteLine("Insira o preço do produto: ");
                dados.preco = double.Parse(Console.ReadLine());
                Console.WriteLine("Insira a quantidade dos produtos: ");
                dados.quantidade = int.Parse(Console.ReadLine());
                if (dados.quantidade >= 1 && dados.preco > 0)
                {
                    CalculadoraDesconto.CalcularDesconto(dados);
                    controle = false;
                }
                else
                {
                    Console.WriteLine("Valores inválidos.");
                }
            }
        }
    }
}