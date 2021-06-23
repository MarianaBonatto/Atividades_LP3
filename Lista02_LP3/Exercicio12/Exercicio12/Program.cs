using System;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("DIGITE ENTRE 1 E 7 : ");
            num = int.Parse(Console.ReadLine());

            switch(num)
            {
                case 1:
                    Console.WriteLine("DOMINGO");
                    break;

                case 2:
                    Console.WriteLine("SEGUNDA-FEIRA");
                    break;

                case 3:
                    Console.WriteLine("TERÇA-FEIRA");
                    break;

                case 4:
                    Console.WriteLine("QUARTA-FEIRA");
                    break;

                case 5:
                    Console.WriteLine("QUINTA-FEIRA");
                    break;

                case 6:
                    Console.WriteLine("SEXTA-FEIRA");
                    break;

                case 7:
                    Console.WriteLine("SÁBADO");
                    break;
            }
        }
    }
}
