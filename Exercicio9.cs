
namespace MeuTp2
{
    internal class Exercicio9
    {
        public static void Executar()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("      CALCULADORA DE SALÁRIO LÍQUIDO     ");
            Console.WriteLine("==========================================");

            double salarioBruto = ObterSalarioBruto();

            double imposto = CalcularImposto(salarioBruto);
            double salarioLiquido = salarioBruto - imposto;

            Console.WriteLine("\n==========================================");
            Console.WriteLine($"Salário Bruto: R$ {salarioBruto:F2}");
            Console.WriteLine($"Desconto de Imposto: R$ {imposto:F2}");
            Console.WriteLine($"Salário Líquido: R$ {salarioLiquido:F2}");
            Console.WriteLine("==========================================");
        }

        public static double ObterSalarioBruto()
        {
            double salario;
            while (true)
            {
                Console.Write("Digite seu salário bruto (R$): ");
                string entrada = Console.ReadLine().Trim().Replace(",", ".");

                if (double.TryParse(entrada, out salario) && salario > 0)
                {
                    return salario;
                }
                else
                {
                    Console.WriteLine("Valor inválido! Digite um número válido para o salário.");
                }
            }
        }

        public static double CalcularImposto(double salarioBruto)
        {
            double imposto = 0;

            if (salarioBruto <= 2000)
            {
                imposto = 0; 
            }
            else if (salarioBruto <= 4000)
            {
                imposto = salarioBruto * 0.10;  
            }
            else if (salarioBruto <= 6000)
            {
                imposto = salarioBruto * 0.15;  
            }
            else
            {
                imposto = salarioBruto * 0.20;  
            }

            return imposto;
        }
    }
}

