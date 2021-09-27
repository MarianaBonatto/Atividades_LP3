using System;
namespace Aula12_LP3
{
    class Quadrado : Forma
    {
        private double lado;

        public Quadrado(double lado)
        {
            base.setCor("AZUL");
            this.lado = lado;
            Console.WriteLine("ÁREA DO QUADRADO É DE " + this.calcularArea() + " m2");
        }

        public Quadrado(double lado, string cor)
        {
            base.setCor(cor);
            this.lado = lado;
            Console.WriteLine("ÁREA DO QUADRADO É DE " + this.calcularArea() + " m2");
        }

        public override double calcularArea()
        {
            return lado * lado;
        }
    }
}