using System;
namespace Aula13_LP3
{
    class Quadrado : IForma
    {
        private double lado;

        public Quadrado(double lado)
        {
            this.lado = lado;
            Console.WriteLine("ÁREA DO QUADRADO É DE " + this.calcularArea() + " m2");
        }

        public double calcularArea()
        {
            return lado * lado;
        }
    }
}