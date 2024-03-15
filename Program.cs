using System;

namespace DescontoSOO
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double preco;
            int quantidade;
            bool controle = true;
            while (controle)
            {
                Console.WriteLine("Insira o nome do produto: ");
                nome = Console.ReadLine();
                Console.WriteLine("Insira o preço do produto: ");
                preco = double.Parse(Console.ReadLine());
                Console.WriteLine("Insira a quantidade dos produtos: ");
                quantidade = int.Parse(Console.ReadLine());
                if (quantidade >= 1 && preco > 0)
                {
                    if (quantidade <= 10)
                    {
                        Console.WriteLine($"{nome} - {quantidade} peças");
                        Console.WriteLine($"O valor do produto é {preco}.");
                        controle = false;
                    }
                    else if (quantidade > 10 && quantidade < 20)
                    {
                        double preco10 = preco - (preco * 0.10);
                        Console.WriteLine($"{nome} - {quantidade} peças");
                        Console.WriteLine($"O valor do produto é {preco10}.");
                        controle = false;
                    }
                    else if (quantidade > 20 && quantidade < 50)
                    {
                        double preco20 = preco - (preco * 0.20);
                        Console.WriteLine($"{nome} - {quantidade} peças");
                        Console.WriteLine($"O valor do produto é {preco20}.");
                        controle = false;
                    }
                    else if (quantidade > 50)
                    {
                        double preco25 = preco - (preco * 0.25);
                        Console.WriteLine($"{nome} - {quantidade} peças");
                        Console.WriteLine($"O valor do produto é {preco25}.");
                        controle = false;
                    }
                    else
                    {
                        Console.WriteLine($"{nome} - {quantidade} peças");
                        Console.WriteLine($"O valor do produto é {preco}");
                        controle = false;
                    }
                }
            }
        }
    }
}
