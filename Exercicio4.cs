

using System;

namespace MeuTp2
{
    internal class Exercicio4
    {
        public static void Executar()
        {
            Console.WriteLine("\n==================================");
            Console.WriteLine("  FORMULÁRIO DE CADASTRO SIMPLES  ");
            Console.WriteLine("==================================\n");

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("\nDigite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite seu telefone ( (11) xxxxx - xxxx ): ");
            string telefone = Console.ReadLine();

            Console.WriteLine("\nDigite seu e-mail: ");
            string email = Console.ReadLine();

            Console.WriteLine("\n==============================");
            Console.WriteLine("       DADOS CADASTRADOS      ");
            Console.WriteLine("==============================");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"Telefone: {telefone}");
            Console.WriteLine($"E-mail: {email}");
            Console.WriteLine("==============================");

        }

        public static int ValidarIdade()
        {
            int idade;
            while (true)
            {
                Console.Write("Digite sua idade: ");
                if (int.TryParse(Console.ReadLine(), out idade) && idade > 0)
                {
                    return idade;
                }
                Console.WriteLine("Erro: Idade inválida. Digite um número inteiro positivo.");
            }
        }

        public static string ValidarTelefone()
        {
            while (true)
            {
                Console.Write("Digite seu telefone ((11) 91234-5678): ");
                string telefone = Console.ReadLine();

                if (System.Text.RegularExpressions.Regex.IsMatch(telefone, @"^\(\d{2}\) \d{5}-\d{4}$"))
                {
                    return telefone;
                }
                Console.WriteLine("Erro: Telefone inválido. Use o formato correto (11) 91234-5678.");
            }
        }

        public static string ValidarEmail()
        {
            while (true)
            {
                Console.Write("Digite seu e-mail: ");
                string email = Console.ReadLine();

                if (email.Contains("@") && email.Contains(".") && email.IndexOf("@") < email.LastIndexOf("."))
                {
                    return email;
                }
                Console.WriteLine("Erro: E-mail inválido. Certifique-se de incluir '@' e um domínio válido.");
            }
        }
    }
}
