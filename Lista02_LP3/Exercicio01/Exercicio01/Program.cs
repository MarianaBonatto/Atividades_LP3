using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("DIGITE UM NÚMERO INTEIRO : ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE OUTRO NÚMERO : ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine("O MAIOR NÚMERO DIGITADO É " + num1);
            else
                Console.WriteLine("O MAIOR NÚMERO DIGITADO É  " + num2);
        }
    }
}
