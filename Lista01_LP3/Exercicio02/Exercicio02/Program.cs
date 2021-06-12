using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            float num = 0;

            Console.WriteLine("Digite um número real : ");
            num = float.Parse(Console.ReadLine());

            Console.WriteLine(" O NÚMERO DIGITADO PELO USUÁRIO FOI " + num);
        }
    }
}
