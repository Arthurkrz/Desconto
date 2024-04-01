using System;

namespace Desconto
{
    public class DadosDesconto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        public double CalcularDesconto()
        {
            if (Quantidade <= 10)
            {
                Console.WriteLine($"{Nome} - {Quantidade} peças");
                Console.WriteLine($"O valor do produto é {Preco}.");
                return Preco;
            }
            else if (Quantidade > 11 && Quantidade <= 20)
            {
                double preco10 = Preco - (Preco * 0.10);
                Console.WriteLine($"{Nome} - {Quantidade} peças");
                Console.WriteLine($"O valor do produto é {preco10}.");
                return preco10;
            }
            else if (Quantidade > 21 && Quantidade <= 50)
            {
                double preco20 = Preco - (Preco * 0.20);
                Console.WriteLine($"{Nome} - {Quantidade} peças");
                Console.WriteLine($"O valor do produto é {preco20}.");
                return preco20;
            }
            else if (Quantidade > 51)
            {
                double preco25 = Preco - (Preco * 0.25);
                Console.WriteLine($"{Nome} - {Quantidade} peças");
                Console.WriteLine($"O valor do produto é {preco25}.");
                return preco25;
            }
            else
            {
                Console.WriteLine($"{Nome} - {Quantidade} peças");
                Console.WriteLine($"O valor do produto é {Preco}.");
                return Preco;
            }
        }
    }
}