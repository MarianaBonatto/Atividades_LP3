using System;
namespace Aula11_LP3
{
    class Sapo : Anfibio
    {
        public Sapo()
        {
            base.Som("");
            this.Som("COACH");
        }

        protected override void Som(string som)
        {
            Console.Write("COACH");
        }
    }
}