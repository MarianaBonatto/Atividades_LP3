using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            //for
            Console.WriteLine("USO DO 'FOR' : ");
            for (num = 1; num <= 100; num++)
                Console.WriteLine(num);

            //While
            int num2 = 1;
            Console.WriteLine();
            Console.WriteLine("USO DO 'WHILE' : ");
            while (num2 <= 100)
            {
                Console.WriteLine(num2);
                ++num2;
            }

            //Do while
            int num3 = 1;
            Console.WriteLine();
            Console.WriteLine("USO DO 'DO WHILE' : ");
            do
            {
                Console.WriteLine(num3);
                num3++;
            }
            while (num3 <= 100);
        }
    }
}
