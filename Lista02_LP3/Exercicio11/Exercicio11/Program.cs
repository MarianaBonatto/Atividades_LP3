using System;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, media, som;

            Console.WriteLine("DIGITE A NOTA DO TRABALHO DE LABORATÓRIO DE 0 A 10 : ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE A NOTA DO EXAME SEMESTRAL DE 0 A 10 : ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE A TERCEIRA NOTA DO EXAME FINAL DE 0 A 10 : ");
            nota3 = double.Parse(Console.ReadLine());

            media = nota1 * 0.2 + nota2 * 0.3 + nota3 * 0.5;


            if ((media >= 0.0) && (media <= 2.9))
                Console.WriteLine("O ALUNO FOI REPROVADO COM " + media + " PONTOS");
            else if ((media >= 3) && (media <= 4.9))
                Console.WriteLine("O ALUNO ESTÁ DE RECUPERAÇÃO COM " + media + " PONTOS");
            else 
                Console.WriteLine("O ALUNO FOI APROVADO COM " + media + " PONTOS");
        }
    }
}
