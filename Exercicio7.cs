

namespace MeuTp2
{
    internal class Exercicio7
    {
        public static void Executar()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("     VERIFICADOR DE NÚMERO PAR OU ÍMPAR    ");
            Console.WriteLine("============================================");

            int numero = ValidarEntrada("Digite um número inteiro: ");

            string resultado = EhImparOuPar(numero);
            Console.WriteLine($"O número {numero} é {resultado}.");
        }

        public static int ValidarEntrada(string mensagem)
        {
            int numero;
            while (true)
            {
                Console.Write(mensagem);
                string entrada = Console.ReadLine();

                // Tenta converter a entrada para inteiro
                if (int.TryParse(entrada, out numero))
                {
                    return numero;  // Retorna o número válido
                }
                else
                {
                    Console.WriteLine("Valor inválido! Por favor, digite um número inteiro.");
                }
            }
        }

        public static string EhImparOuPar(int num)
        {
            if (num % 2 == 0)
            {
                return "par";
            }
            else
            {
                return "ímpar";
            }
        }
    }
}
