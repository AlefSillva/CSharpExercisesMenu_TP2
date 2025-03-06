

namespace MeuTp2
{
    internal class Exercicio12
    {
        public static void Executar()
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("      JOGO DE ADIVINHAÇÃO    ");
            Console.WriteLine("==============================");


            Random numAleatorio = new Random();
            int numeroOculto = numAleatorio.Next(1, 101);
            int palpite = 0;

            while (palpite != numeroOculto)
            {
                Console.Write("Digite outro palpite: ");

                if (int.TryParse(Console.ReadLine(), out palpite))
                {
                    if (palpite < numeroOculto)
                    {
                        Console.WriteLine("O número oculto é maior! Tente novamente.");
                    }
                    else if (palpite > numeroOculto)
                    {
                        Console.WriteLine("O número secreto é menor! Tente novamente.");
                    }
                    else
                    {
                        Console.WriteLine($"Parabéns! Você acertou o número {numeroOculto}.");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, insira um número válido.");
                }
            }

            Console.WriteLine("Tente advinhar o número, digite seu palpite de 0 a 100: ");
        }
    }
}
