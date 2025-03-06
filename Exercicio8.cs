
namespace MeuTp2
{
    internal class Exercicio8
    {
        public static void Executar()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("      CLASSIFICAÇÃO DE NOTA ESCOLAR    ");
            Console.WriteLine("==========================================");

            double nota = ObterNotaValida("\nDigite sua nota (0 a 10): ");

            string classificacao = ClassificarNota(nota);

            Console.WriteLine($"De acordo com a not ainformada: {nota}. Seu desempenho foi {classificacao}.");

        }

        public static double ObterNotaValida(string mensagem)
        {
            double nota;
            while (true)
            {
                Console.Write(mensagem);
                string entrada = Console.ReadLine().Trim().Replace(".", ",");

                if (double.TryParse(entrada, out nota) && nota >= 0 && nota <= 10)
                {
                    return nota;
                }
                else
                {
                    Console.WriteLine("Valor inválido! Por favor, insira uma nota entre 0 e 10.");
                }
            }
        }

        public static string ClassificarNota(double nota)
        {
            if (nota < 5)
            {
                return "Insuficiente";
            }
            else if (nota >= 5 && nota < 7)
            {
                return "Regular";
            }
            else if (nota >= 7 && nota < 9)
            {
                return "Bom";
            }
            else
            {
                return "Excelente";
            }
        }
    }
}
