
using System;
namespace Aula11_LP3
{
    class Reptil : Animal
    {
        public Reptil()
        {
            base.Som("");
        }

        protected override void Som(string som)
        {
            Console.Write("BAIXO-> ");
        }
    }
}