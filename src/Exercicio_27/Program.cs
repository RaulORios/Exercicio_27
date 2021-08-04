using System;

namespace Exercicio_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("*********     Exercicio 27     *********");
            Console.WriteLine("****************************************");

            Console.WriteLine("");

            int numero1;
            
            Console.Write("Digite um número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
                        
            Console.WriteLine("");

            if (numero1 == 0)
            {
                Console.WriteLine($"O número '{ numero1}' é ZERO.");
            }
            else if (numero1 > 0)
            {
                Console.WriteLine($"O número '{ numero1}' é POSITIVO.");
            }
            else
            {
                Console.WriteLine($"O número '{ numero1}' é NEGATIVO.");
            }
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
