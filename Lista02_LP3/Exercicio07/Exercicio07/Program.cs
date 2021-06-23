using System;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, prestacao;

            Console.WriteLine("DIGITE O VALOR DO SALÁRIO : ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE O VALOR DA PRESTAÇÃO : ");
            prestacao = double.Parse(Console.ReadLine());

            if(prestacao > (salario*20/100))
                Console.WriteLine("EMPRÉSTIMO NÃO CONCEDIDO");
            else
                Console.WriteLine("EMPRÉSTIMO CONCEDIDO");
        }
    }
}
