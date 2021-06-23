using System;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            double l1, l2, l3;

            Console.WriteLine("DIGITE O LADO 01 : ");
            l1 = double.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE O LADO 02 : ");
            l2 = double.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE O LADO 03 : ");
            l3 = double.Parse(Console.ReadLine());

            if ((l1 <= 0) || (l2 <= 0) || (l3 <= 0))
                Console.WriteLine("OS VALORES INDICADOS NÃO FORMAM UM TRIÂNGULO");
            else if ((l1 == l2) && (l1 == l3) && (l2 == l3))
                Console.WriteLine("OS VALORES INFORMADOS FORMAM UM TRIÂNGULO EQUILÁTERO");
            else if ((l1 == l2) || ((l1 == l3) || (l2 == l3)))
                Console.WriteLine("OS VALORES INFORMADOS FORMAM UM TRIÂNGULO ISÓCELES");
            else if ((l1 != l2) && (l1 != l3) && (l2 != l3)) 
                     Console.WriteLine("OS VALORES INFORMADOS FORMAM UM TRIÂNGULO ESCALENO");
        }
    }
}
