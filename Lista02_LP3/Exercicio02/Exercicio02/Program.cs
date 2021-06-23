using System;


namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, quadrado, raiz;

            Console.WriteLine("DIGITE UM NÚMERO : ");
            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                quadrado = num * num;
                raiz = Math.Sqrt(num);

                Console.WriteLine("O QUADRADO DO NÚMERO " + num + " É " + quadrado);
                Console.WriteLine("A RAIZ QUADRADA DE " + num + " É " + raiz);
            }
        }
    }
}
