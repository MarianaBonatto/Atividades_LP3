using System;

namespace Aula03_LP3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 2.5, b = 2.5;
            double resultado;
            
            //OPERADORES MATEMÁTICOS
            resultado = a + b;
            Console.WriteLine("O resultado da soma é : " + resultado);

            resultado = a - b;
            Console.WriteLine("O resultado da subtração é : " + resultado);

            resultado = a * b;
            Console.WriteLine("O resultado da multiplicação é : " + resultado);

            resultado = a / b;
            Console.WriteLine("O resultado da divisão é : " + resultado);

            resultado = a % b;
            Console.WriteLine("O resto da divisão é : " + resultado);

            //OPERADORES DE COMPARAÇÃO
            int m = 100, d = 180;

            if (m == d)
                Console.WriteLine("\nOs operandos são iguais");
            else
                Console.WriteLine("Os operandos são diferentes");

            if (m != d)
                Console.WriteLine("Os operandos são diferentes");
            else
                Console.WriteLine("Os operandos são iguais");

            if (m > d)
                Console.WriteLine("O primeiro operando é maior que o segundo");
            else
                Console.WriteLine("O primeiro operando é menor ou igual ao segundo");

            //OPERADORES LÓGICOS
            double media = 7.5, presenca = 80.0;

            if ((media >= 6) && (presenca >= 75))
                Console.WriteLine("\nO aluno foi aprovado");
            else
                Console.WriteLine("O aluno foi reprovado");

            string nota = "Ótimo";

            if ((nota == "Ótimo") || (nota == "Boa"))
                Console.WriteLine("O aluno foi aprovado");
            else
                Console.WriteLine("O aluno foi reprovado");

            string situacao = " Reprovado";

            if (!(situacao == "Aprovado"))
                Console.WriteLine("O aluno foi reprovado");
            else
                Console.WriteLine("O aluno foi aprovado");

        }
    }
}
