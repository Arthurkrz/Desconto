using System;

namespace Desconto
{
    class Program
    {
        static void Main(string[] args)
        {
            DadosDesconto dadosdesconto = new DadosDesconto();
            Console.WriteLine("Insira o nome do produto: ");
            dadosdesconto.Nome = Console.ReadLine();
            Console.WriteLine("Insira o preço do produto: ");
            dadosdesconto.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade dos produtos: ");
            dadosdesconto.Quantidade = int.Parse(Console.ReadLine());
            if (dadosdesconto.Quantidade >= 1 && dadosdesconto.Preco > 0)
            {
                dadosdesconto.CalcularDesconto();
            }
            else
            {
                Console.WriteLine("Valores inválidos.");
            }
        }
    }
}