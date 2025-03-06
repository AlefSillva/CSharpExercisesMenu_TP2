using MeuTp2;

public class Program
{
    public static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("        ESCOLHA UM EXERCÍCIO        ");
            Console.WriteLine("====================================");
            Console.WriteLine("1 - Cálculo de Idade Precisa");
            Console.WriteLine("2 - Dias até o Próximo Aniversário ");
            Console.WriteLine("3 - Diferença Entre Duas Datas");
            Console.WriteLine("4 - Formulário de Cadastro Simples");
            Console.WriteLine("5 - Conversor de Temperatura");
            Console.WriteLine("6 - Cálculo de IMC ");
            Console.WriteLine("7 - Verificador de Número Par ou Ímpar ");
            Console.WriteLine("8 - Classificação de Nota Escolar");
            Console.WriteLine("9 - Calculadora de Salário Líquido");
            Console.WriteLine("10 - Contagem Regressiva");
            Console.WriteLine("11 - Tabuada Interativa");
            Console.WriteLine("12 - Jogo de Adivinhação");
            Console.WriteLine("0 - SAIR\n");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Console.WriteLine("Executando o exercício 1...");
                    Exercicio1.Executar();
                    break;
                case "2":
                    Console.WriteLine("Executando o exercício 2...");
                    Exercicio2.Executar();
                    break;
                case "3":
                    Console.WriteLine("Executando o exercício 3...");
                    Exercicio3.Executar();
                    break;
                case "4":
                    Exercicio4.Executar();
                    break;
                case "5":
                    Exercicio5.Executar();
                    break;
                case "6":
                    Exercicio6.Executar();
                    break;
                case "7":
                    Exercicio7.Executar();
                    break;
                case "8":
                    Exercicio8.Executar();
                    break;
                case "9":
                    Exercicio9.Executar();
                    break;
                case "10":
                    Exercicio10.Executar();
                    break;
                case "11":
                    Exercicio11.Executar();
                    break;
                case "12":
                    Exercicio12.Executar();
                    break;
                case "0":
                    Console.WriteLine("Saindo do programa...");
                    continuar = false;
                    return;
                default:
                    Console.WriteLine("Opção Inválida.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

    }
}