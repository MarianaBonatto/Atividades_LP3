using System;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, basema, baseme, alt;

            Console.WriteLine("DIGITE A ALTURA DO TRAPÉZIO : ");
            alt = double.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE A BASE MAIOR DO TRAPÉZIO : ");
            basema = double.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE A BASE MENOR DO TRAPÉZIO : ");
            baseme = double.Parse(Console.ReadLine());

            if (basema > 0 && baseme > 0)
            {
                area = (((basema + baseme) * alt) / 2);
                Console.WriteLine("A ÁREA DESSE TRAPÉZIO TEM O VALOR DE " + area);
            }
            else
                Console.WriteLine("IMPOSSÍVEL CALCULAR, DIGITE VALORES MAIORES QUE ZERO");
        }
    }
}
