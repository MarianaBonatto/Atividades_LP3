using System;
namespace Aula13_LP3
{
    class Triangulo : IForma
    {
        private double Base;
        private double altura;

        public Triangulo(double Base, double altura)
        {
            this.Base = Base;
            this.altura = altura;
            Console.WriteLine("ÁREA DO TRIÂNGULO É DE " + this.calcularArea() + " m2");
        }

        public double calcularArea()
        {
            return (Base * altura) / 2;
        }
    }
}