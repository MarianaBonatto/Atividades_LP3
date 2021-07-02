using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int ma = 0, me = 0, num = 0;

            do
            {
                Console.WriteLine("DIGITE UM NÚMERO POSITIVO OU UM NEGATIVO PARA ENCERRAR O PROGRAMA : ");
                num = int.Parse(Console.ReadLine());

                if (num > ma)
                    ma = num;

                if (num < ma && num >= 0)
                    me = num;

            }
            while (num >= 0);
            Console.WriteLine("FIM DO PROGRAMA");
            Console.WriteLine("O MAIOR NÚMERO DIGITADO FOI " + ma);
            Console.WriteLine("O MENOR NÚMERO DIGITADO FOI " + me);
        }
    }
}
