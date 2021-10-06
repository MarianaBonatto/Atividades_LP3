using System;
namespace Aula13_LP3
{
    class Circulo : IForma
    {
        private double raio;

        public Circulo(double raio)
        {
            this.raio = raio;
            Console.WriteLine("ÁREA DO CÍRCULO É DE " + this.calcularArea() + " m2");
        }

        public double calcularArea()
        {
            return 3.14 * (raio * raio);
        }
    }
}