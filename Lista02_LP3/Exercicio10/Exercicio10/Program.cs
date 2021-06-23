using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, media;

            Console.WriteLine("DIGITE A PRIMEIRA NOTA : ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE A SEGUNDA NOTA : ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE A TERCEIRA NOTA : ");
            nota3 = double.Parse(Console.ReadLine());

            media = ((nota1 * 1) + (nota2 * 1) + (nota3 * 2)) / 3;

            if (media >= 60.0)
                Console.WriteLine("ALUNO APROVADO COM " + media + " PONTOS");
            else
                Console.WriteLine("ALUNO REPROVADO COM " + media + " PONTOS");
        }
    }
}
