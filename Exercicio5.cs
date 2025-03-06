

namespace MeuTp2
{
    internal class Exercicio5
    {
        public static void Executar()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("    CONVERSOR DE TEMPERATURA   ");
            Console.WriteLine("===============================");


            int temperaturaValida = 0;
            bool inputValido = false;

            while (!inputValido)
            {
                Console.Write("Digite a temperatura em graus Celsius: ");
                string temperaturaCelsius = Console.ReadLine();

                if (!int.TryParse(temperaturaCelsius, out temperaturaValida))
                {
                    Console.WriteLine("Erro: Entrada inválida. Digite um número inteiro.");
                    return;
                }
                else
                {
                    inputValido = true;
                }
            }

            bool ficaNoLoop = true;
            while (ficaNoLoop)
            {

                Console.WriteLine("\nESCOLHA PARAA QUAL OPÇÃO QUE DESEJA CONVERTER:");
                Console.WriteLine("1 - Celsius para Fahrenheit");
                Console.WriteLine("2 - Celsius para Kelvin");

                int temperaturaFahrenheit = CelsiusParaFahrenheit(temperaturaValida);
                double temperaturaKelvin = CelsiusParaKelvin(temperaturaValida);

                string escolha = Console.ReadLine();


                if (!string.IsNullOrEmpty(escolha))
                {
                    switch (escolha)
                    {
                        case "1":
                            Console.WriteLine($"{temperaturaValida}ºC equivalem a {temperaturaFahrenheit}ºF.");
                            ficaNoLoop = false;
                            break;
                        case "2":
                            Console.WriteLine($"{temperaturaValida}ºC equivalem a {temperaturaKelvin}ºK.");
                            ficaNoLoop = false;
                            break;
                    }
                    return;
                }
                
            }

           
        }
            
        public static int CelsiusParaFahrenheit(int c)
        {
            return (c * 9 / 5) + 32;
        }

        public static double CelsiusParaKelvin(int c)
        {
            return c + 273.15;
        }
    }
}

