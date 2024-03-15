using System;

namespace Desconto
{
    public class CalculadoraDesconto
    {
        public static double CalcularDesconto(Dados dados)
        {
            if (dados.quantidade <= 10)
            {
                Console.WriteLine($"{dados.nome} - {dados.quantidade} peças");
                Console.WriteLine($"O valor do produto é {dados.preco}.");
                return dados.preco;
            }
            else if (dados.quantidade > 10 && dados.quantidade < 20)
            {
                double preco10 = dados.preco - (dados.preco * 0.10);
                Console.WriteLine($"{dados.nome} - {dados.quantidade} peças");
                Console.WriteLine($"O valor do produto é {preco10}.");
                return preco10;
            }
            else if (dados.quantidade > 20 && dados.quantidade < 50)
            {
                double preco20 = dados.preco - (dados.preco * 0.20);
                Console.WriteLine($"{dados.nome} - {dados.quantidade} peças");
                Console.WriteLine($"O valor do produto é {preco20}.");
                return preco20;
            }
            else if (dados.quantidade > 50)
            {
                double preco25 = dados.preco - (dados.preco * 0.25);
                Console.WriteLine($"{dados.nome} - {dados.quantidade} peças");
                Console.WriteLine($"O valor do produto é {preco25}.");
                return preco25;
            }
            else
            {
                Console.WriteLine($"{dados.nome} - {dados.quantidade} peças");
                Console.WriteLine($"O valor do produto é {dados.preco}.");
                return dados.preco;
            }
        }
    }
}
