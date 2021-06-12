using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0, num3 = 0, res = 0;

            Console.WriteLine("Digite um número inteiro : ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um outro número inteiro : ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite mais um número inteiro : ");
            num3 = int.Parse(Console.ReadLine());

            res = num1 + num2 + num3;

            Console.WriteLine(num1 + " + " + num2 + " + " + num3 + " = " + res);
        }
    }
}
