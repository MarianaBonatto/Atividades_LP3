using System;
namespace Aula13_LP3
{
    class Retangulo : IForma
    {
        private double lado1;
        private double lado2;

        public Retangulo(double lado1, double lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            Console.WriteLine("ÁREA DO RETÂNGULO É DE " + this.calcularArea() + " m2");
        }

        public double calcularArea()
        {
            return lado1 * lado2;
        }
    }
}