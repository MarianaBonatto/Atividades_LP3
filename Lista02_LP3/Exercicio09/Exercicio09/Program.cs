using System;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, soma = 0;

            Console.WriteLine("DIGITE UM NÚMERO INTEIRO : ");
            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                while (num > 0)
                {
                    soma = soma + num % 10;
                    num = num / 10;
                }
                Console.WriteLine("A SOMA DOS ALGARISMOS É " + soma);
            }
            else
                Console.WriteLine("NÚMERO INVÁLIDO");
        }
    }
}
