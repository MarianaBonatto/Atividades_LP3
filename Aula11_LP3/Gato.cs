using System;
namespace Aula11_LP3
{
    class Gato : Mamifero
    {
        public Gato()
        {
            base.Som("");
            this.Som("MIAU");
        }

        protected override void Som(string som)
        {
            Console.Write("MIAU");
        }
    }
}