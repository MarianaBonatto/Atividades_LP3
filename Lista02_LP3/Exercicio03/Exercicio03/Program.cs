using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("DIGITE UM NÚMERO INTEIRO : ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("O NÚMERO " + num + " É PAR");
            else
                Console.WriteLine("O NÚMERO " + num + " É ÍMPAR");
        }
    }
}
