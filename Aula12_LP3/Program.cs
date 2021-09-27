using System;

namespace Aula12_LP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUADRADO 01 : ");
            Quadrado q1 = new Quadrado(2.0);
            Console.WriteLine("");
            Console.WriteLine("QUADRADO 02 : ");
            Quadrado q2 = new Quadrado(10.0, "ROSA");

            Console.WriteLine("");
            Console.WriteLine("RETÂNGULO 01 : ");
            Retangulo r1 = new Retangulo(2.0, 3.5);
            Console.WriteLine("");
            Console.WriteLine("RETÂNGULO 02 : ");
            Retangulo r2 = new Retangulo(2.0, 10.2, "VERMELHO");

            Console.WriteLine("");
            Console.WriteLine("CÍRCULO 01 : ");
            Circulo c1 = new Circulo(5.0);
            Console.WriteLine("");
            Console.WriteLine("CÍRCULO 02 : ");
            Circulo c2 = new Circulo(8.6, "VERDE");

            Console.WriteLine("");
            Console.WriteLine("TRIÂNGULO 01 : ");
            Triangulo t1 = new Triangulo(4.0, 4.0);
            Console.WriteLine("");
            Console.WriteLine("TRIÂNGULO 02 : ");
            Triangulo t2 = new Triangulo(8.6, 10.9, "LARANJA");
        }
    }
}
