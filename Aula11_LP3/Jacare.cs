
using System;
namespace Aula11_LP3
{
    class Jacare : Reptil
    {
        public Jacare()
        {
            base.Som("BAIXO");
            this.Som("SSSSSS");
        }

        protected override void Som(string som)
        {
            Console.Write("SSSSSS");
        }
    }
}