using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2;

            Console.WriteLine("DIGITE A PRIMEIRA NOTA : ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE A SEGUNDA NOTA : ");
            nota2 = double.Parse(Console.ReadLine());

            if ((nota1 >= 0.0 && nota1 <= 10.0) && (nota2 >= 0.0 && nota2 <= 10.0))
                Console.WriteLine("NOTAS VÁLIDAS");
            else
                Console.WriteLine("NOTAS INVÁLIDAS");
        }
    }
}
