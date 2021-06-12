using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            float num = 0, res = 0;

            Console.WriteLine("Digite um número real : ");
            num = float.Parse(Console.ReadLine());

            res = num / 5;

            Console.WriteLine("A QUINTA PARTE DESSE NÚMERO É " + res);
        }
    }
}
