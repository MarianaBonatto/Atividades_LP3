using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, res;

            Console.WriteLine("DIGITE UM NÚMERO INTEIRO : ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE UM OUTRO NÚMERO INTEIRO : ");
            num2 = int.Parse(Console.ReadLine());

            if(num1 > num2)
            {
                res = num1 - num2;
                Console.WriteLine("O MAIOR NÚMERO É " + num1);
                Console.WriteLine("A DIFERENÇA DELES É " + res);
            } else
            {
                res = num2 - num1;
                Console.WriteLine("O MAIOR NÚMERO É " + num2);
                Console.WriteLine("A DIFERENÇA DELES É " + res);
            }
        }
    }
}
