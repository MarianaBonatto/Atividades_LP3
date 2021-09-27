using System;
namespace Aula12_LP3
{
    class Triangulo : Forma
    {
        private double Base;
        private double altura;

        public Triangulo(double Base, double altura)
        {
            base.setCor("AMARELO");
            this.Base = Base;
            this.altura = altura;
            Console.WriteLine("ÁREA DO TRIÂNGULO É DE " + this.calcularArea() + " m2");
        }

        public Triangulo(double Base, double altura, string cor)
        {
            base.setCor(cor);
            this.Base = Base;
            this.altura = altura;
            Console.WriteLine("ÁREA DO TRIÂNGULO É DE " + this.calcularArea() + " m2");
        }

        public override double calcularArea()
        {
            return (Base * altura) / 2;
        }
    }
}