using System;
namespace Aula12_LP3
{
    class Circulo : Forma
    {
        private double raio;

        public Circulo(double raio)
        {
            base.setCor("VERMELHO");
            this.raio = raio;
            Console.WriteLine("ÁREA DO CÍRCULO É DE " + this.calcularArea() + " m2");
        }

        public Circulo(double raio, string cor)
        {
            base.setCor(cor);
            this.raio = raio;
            Console.WriteLine("ÁREA DO CÍRCULO É DE " + this.calcularArea() + " m2");
        }

        public override double calcularArea()
        {
            return 3.14 * (raio * raio);
        }
    }
}