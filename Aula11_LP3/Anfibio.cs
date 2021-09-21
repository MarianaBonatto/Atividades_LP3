
using System;
namespace Aula11_LP3
{
    class Anfibio : Animal
    {
        public Anfibio()
        {
            base.Som("");
        }

        protected override void Som(string som)
        {
            Console.Write("MÉDIO -> ");
        }
    }
}