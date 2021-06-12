using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            Console.WriteLine("Digite um número inteiro : ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("O NÚMERO DIGITADO PELO USUÁRIO FOI " + num);
        }
    }
}
