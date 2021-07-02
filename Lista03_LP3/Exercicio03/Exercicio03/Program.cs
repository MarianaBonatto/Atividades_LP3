using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, n = 0, soma = 0;

            do
            {
                Console.WriteLine("ESCREVA UM NÚMERO INTEIRO : ");
                num = int.Parse(Console.ReadLine());

                soma = soma + num;

                n++;
            }
            while (n < 10);
            Console.WriteLine("A SOMA DOS NÚMEROS DIGITADO É " + soma);
            Console.WriteLine("FIM DO PROGRAMA!");
        }
    }
}
