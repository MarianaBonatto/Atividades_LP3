using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0, res = 0;

            Console.WriteLine("Digite um número real : ");
            num1 = float.Parse(Console.ReadLine());

            res = num1*num1;

            Console.WriteLine("O QUADRADO DESSE NÚMERO É " + res);
        }
    }
}
