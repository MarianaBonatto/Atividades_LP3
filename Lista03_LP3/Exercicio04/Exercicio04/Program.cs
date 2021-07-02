using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, n = 0;

            Console.WriteLine("DIGITE UM NÚMERO INTEIRO : ");
            num = int.Parse(Console.ReadLine());

            for(n = 0; n < num; ++n)
            {
                if (n % 2 != 0)
                    Console.WriteLine("O NÚMERO " + n + " É ÍMPAR");
            }
        }
    }
}
