using System;
namespace Aula12_LP3
{
    class Retangulo : Forma
    {
        private double lado1;
        private double lado2;

        public Retangulo(double lado1, double lado2)
        {
            base.setCor("ROXO");
            this.lado1 = lado1;
            this.lado2 = lado2;
            Console.WriteLine("ÁREA DO RETÂNGULO É DE " + this.calcularArea() + " m2");
        }

        public Retangulo(double lado1, double lado2, string cor)
        {
            base.setCor(cor);
            this.lado1 = lado1;
            this.lado2 = lado2;
            Console.WriteLine("ÁREA DO RETÂNGULO É DE " + this.calcularArea() + " m2");
        }

        public override double calcularArea()
        {
            return lado1 * lado2;
        }
    }
}