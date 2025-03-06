
namespace MeuTp2
{
    internal class Exercicio11
    {
        public static void Executar()
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("      TABUADA INTERATIVA    ");
            Console.WriteLine("==============================");

            Console.WriteLine("Digite um número inteiro para ver a sua tabuada: ");

            while (true)
            {
                int num;

                if (int.TryParse(Console.ReadLine(), out num) && num > 0)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"{num} x {i} = {num * i}");
                        
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("ERRO. Digite um número inteiro: ");
                }
            }
        }
    }
}
