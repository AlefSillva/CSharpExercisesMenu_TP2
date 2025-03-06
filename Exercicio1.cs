

namespace MeuTp2
{
    internal class Exercicio1
    {
        public static void Executar()
        {
            bool taCerto = true;

            while (taCerto)
            {
                Console.WriteLine("====================================");
                Console.WriteLine("        CALCULADORA DE IDADE        ");
                Console.WriteLine("====================================");

                Console.Write("Digite sua data de nascimento (dd/mm/yyyy): ");
                string dataNascimento = Console.ReadLine();

                if (dataNascimento.Length != 10 || dataNascimento[2] != '/' || dataNascimento[5] != '/')
                {
                    Console.WriteLine("\nPor favor, digite a data no formato correto (dd/mm/yyyy): ");
                    continue;
                }

                string[] partes = dataNascimento.Split("/");

                bool diaValido = int.TryParse(partes[0], out int dia);
                bool mesValido = int.TryParse(partes[1], out int mes);
                bool anoValido = int.TryParse(partes[2], out int ano);

                if (!diaValido || !mesValido || !anoValido)
                {
                    Console.WriteLine("Data Inválida. Digite o formato correto (dd/mm/yyyy).");
                    continue;
                }
               
                if ((dia >= 1 && dia <= 31) && (mes >= 1 && mes <= 12) && ano >= 1900)
                {
                    try
                    {
                        DateTime dataValida = new DateTime(ano, mes, dia);

                        var idade = CalculaIdade(dataValida);
                        taCerto = false;

                        Console.WriteLine($"\nVocê tem {idade.Item1} anos, {idade.Item2} mese(s) e {idade.Item3} dia(s).");
                    }
                    catch
                    {
                        Console.WriteLine("Data Inválida. Tente novamente.");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, insira uma data válida.");
                }
            }
        }

        public static (int, int, int) CalculaIdade(DateTime dataNascimento)
        {
            DateTime dataAtual = DateTime.Now;

            TimeSpan diferenca = dataAtual - dataNascimento;

            int anos = diferenca.Days / 365;
            DateTime dataAjustada = dataNascimento.AddYears(anos);

            int meses = dataAtual.Month - dataAjustada.Month;
            if (meses < 0)
            {
                meses += 12;
            }

            int dias = (dataAtual - dataAjustada.AddMonths(meses)).Days;

            // caso o dia ainda não tenha chegado.
            if (dataAtual.Day < dataAjustada.Day)
            {
                meses--;
                dias = dataAtual.Day + DateTime.DaysInMonth(dataAjustada.Year, dataAjustada.Month) - dataAjustada.Day;
            }

            return (anos, meses, dias);
        }
    }
}
