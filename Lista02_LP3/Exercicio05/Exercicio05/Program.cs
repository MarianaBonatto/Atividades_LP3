using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("DIGITE UM NÚMERO INTEIRO : ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE UM OUTRO NÚMERO INTEIRO : ");
            num2 = int.Parse(Console.ReadLine());

            if(num1 > num2)
                Console.WriteLine("O MAIOR NÚMERO É " + num1);
            else if(num2 > num1)
                Console.WriteLine("O MAIOR NÚMERO É " + num2);
            else
                Console.WriteLine("OS NÚMEROS SÃO IGUAIS ");
        }
    }
}
