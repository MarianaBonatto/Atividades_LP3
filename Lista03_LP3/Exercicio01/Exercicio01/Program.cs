using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            Console.WriteLine("OS 5 PRIMEIROS MÚLTIPLOS DE 3 SÃO : ");
            for (n = 0; n <= 15; ++n)
            {
                if(n %3 == 0 && n > 0)
                Console.WriteLine(n);
            }
            Console.WriteLine("FIM DO PROGRAMA");
        }
    }
}
