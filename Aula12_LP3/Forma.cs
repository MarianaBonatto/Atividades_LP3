using System;
namespace Aula12_LP3
{
    abstract class Forma
    {
        private string cor;

        protected void setCor(string cor)
        {
            this.cor = cor;
            Console.WriteLine("A COR DA FORMA É " + this.cor);
        }

        public abstract double calcularArea();
    }
}