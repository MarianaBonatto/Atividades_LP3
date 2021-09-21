
using System;
namespace Aula11_LP3
{
    class Mamifero : Animal
    {
        public Mamifero()
        {
            base.Som("");
        }

        protected override void Som(string som)
        {
            Console.Write("ALTO -> ");
        }
    }
}