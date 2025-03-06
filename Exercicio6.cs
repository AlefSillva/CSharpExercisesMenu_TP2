

namespace MeuTp2
{
    internal class Exercicio6
    {
        public static void Executar()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("         CÁLCULO DE IMC      ");
            Console.WriteLine("===============================");

            double peso = ObterValorValido("\nDigite seu peso (Kg): ");
            double altura = ObterValorValido("\nDigite sua altura (m): ");

            double imc = CalcularImc(peso, altura);
            string classificacao = ClassificarImc(imc);

            Console.WriteLine($"\nSeu IMC: {imc:F2}. Classificação: {classificacao}.");
        }

        public static double ObterValorValido(string mensagem)
        {
            while (true)
            {
                Console.Write(mensagem);
                string entrada = Console.ReadLine().Replace("." , ",");

                if (double.TryParse(entrada, out double valor))
                {
                    return valor;
                }
                else
                {
                    Console.WriteLine("Valor inválido! Digite um número positivo.");
                }
            }
        }

        public static double CalcularImc(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        public static string ClassificarImc(double imc)
        {
            if (imc < 18.5)
            {
                return "Abaixo do Peso";
            }
            else if (imc < 25)
            {
                return "Peso Normal";
            }
            else if (imc < 30)
            {
                return "Sobrepeso";
            }
            else if (imc < 35)
            {
                return "Obesidade Grau I";
            }
            else if (imc < 40)
            {
                return "Obesidade Grau II";
            }
            else
            {
                return "Obesidade Grau III ou Móbida";
            }
        }
    }
}
