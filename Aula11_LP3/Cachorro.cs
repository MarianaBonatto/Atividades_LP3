using System;
namespace Aula11_LP3
{
    class Cachorro : Mamifero
    {
        public Cachorro()
        {
            base.Som("ALTO");
            this.Som("AU AU");
        }

        protected override void Som(string som)
        {
            Console.Write("AU AU");
        }
    }
}