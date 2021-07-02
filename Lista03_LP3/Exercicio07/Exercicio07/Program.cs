using System;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            int  n = 1, num = 0;

            Console.WriteLine("DIGITE UM NÚMERO POSITIVO PAR : ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (n = 1; n <= num; ++n)
            {
                if (n % 2 == 0)
                    Console.WriteLine(n);
                else if (num % 2 != 0)
                { 
                    Console.WriteLine("O NÚMERO DIGITADO NÃO É UM NÚMERO PAR");
                    break;
                }
            }
            Console.WriteLine("FIM DO PROGRAMA");
        }
    }
}
