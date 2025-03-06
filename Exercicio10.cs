namespace MeuTp2
{
    internal class Exercicio10
    {
        public static void Executar()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("      CONTAGEM REGRESSIVA    ");
            Console.WriteLine("===============================");


            Console.WriteLine("Digite um número inteiro para iniciar a contagem regressiva: ");
            int numeroInt; 

           
            if (int.TryParse(Console.ReadLine(), out numeroInt))
            {
                
                for (int i = numeroInt; i >= 1; i--)
                {
                    
                    if (i != numeroInt)
                    {
                        Console.Write(", ");
                    }
                    Console.Write(i);
                }
                Console.WriteLine(); 
            }
            else
            {
                Console.WriteLine("Erro, digite um número inteiro válido.");
            }
        }
    }
}
