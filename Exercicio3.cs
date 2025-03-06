

using System.Security.Cryptography.X509Certificates;

namespace MeuTp2
{
    internal class Exercicio3
    {
        public static void Executar()
        {

            Console.WriteLine("\n==============================");
            Console.WriteLine("  DIFERENÇA ENTRE DUAS DATAS  ");
            Console.WriteLine("==============================\n");

            DateTime data1 = ValidarData("Digite a primeira data (dd/mm/yyyy): ");
            DateTime data2 = ValidarData("Digite a segunda data (dd/mm/yyyy): ");

            var resultado = CalcularDiferencaEntreDatas(data1, data2);

            Console.WriteLine($"\nA diferença é de {resultado.Item1} anos, {resultado.Item2} meses e {resultado.Item3} dias.");

        }

        public static DateTime ValidarData(string mensagem)
        {
            DateTime dataValida = DateTime.MinValue;

            while (true)
            {
                Console.WriteLine(mensagem);
                string data = Console.ReadLine();

                if (data.Length != 10 || data[2] != '/' || data[5] != '/')
                {
                    Console.WriteLine("\nPor favor, digite a data no formato correto (dd/mm/yyyy): ");
                    continue;
                }

                string[] partes = data.Split("/");

                bool diaValido = int.TryParse(partes[0], out int dia);
                bool mesValido = int.TryParse(partes[1], out int mes);
                bool anoValido = int.TryParse(partes[2], out int ano);

                if (!diaValido || !mesValido || !anoValido)
                {
                    Console.WriteLine("Erro: A data contém valores inválidos. Use apenas números.");
                    continue;
                }

                if (!(dia >= 1 && dia <= 31) || !(mes >= 1 && mes <= 12) || ano < 1900)
                {
                    Console.WriteLine("Erro: A data informada está fora dos limites válidos.");
                    continue;
                }

                try
                {
                    dataValida = new DateTime(ano, mes, dia);
                    return dataValida;
                }
                catch
                {
                    Console.WriteLine("Erro: A data informada não é válida. Verifique os valores.");
                }
            }
        }
        public static (int, int, int) CalcularDiferencaEntreDatas(DateTime data1, DateTime data2)
        {
            if (data1 > data2)
            {
                DateTime temporaria = data1;
                data1 = data2;
                data2 = temporaria;
            }

            // diferença entre as datas.
            TimeSpan diferenca = data2 - data1;

            // conversão em anos, meses e dias.
            int anos = diferenca.Days / 365;
            int meses = (diferenca.Days % 365) / 30;
            int dias = diferenca.Days % 30;

            if (data2.Month < data1.Month || (data2.Month == data1.Month && data2.Day < data1.Day))
            {
                anos--;
            }

            if (data2.Day < data1.Day)
            {
                meses--;
                dias -= DateTime.DaysInMonth(data2.Year, data2.Month);
            }

            if (meses < 0)
            {
                meses += 12;
            }

            return (anos, meses, dias);
        }
    }
}
