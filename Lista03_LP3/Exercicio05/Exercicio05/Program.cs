using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, n = 1;


            Console.WriteLine("DIGITE UM NÚMERO INTEIRO : ");
            num = int.Parse(Console.ReadLine());
            n = num + 1;
            
            while (n >= num)
            {
                if ((n % 11 == 0) || (n % 13 == 0) || (n % 17 == 0))
                {
                    Console.WriteLine(n);
                    break;
                }
                n++;
            }
        }
    }
}
