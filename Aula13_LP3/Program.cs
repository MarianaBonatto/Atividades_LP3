using System;

namespace Aula13_LP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IForma f1 = new Quadrado(10.0);
            f1 = new Retangulo(5.0, 7.5);
            f1 = new Circulo(3.6);
            f1 = new Triangulo(2.0, 8.0);
        }
    }
}
