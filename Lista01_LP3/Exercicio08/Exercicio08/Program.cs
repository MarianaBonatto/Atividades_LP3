using System;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            double kel = 0, cel = 0;

            Console.WriteLine("Digite uma temperatura em Kelvin : ");
            kel = double.Parse(Console.ReadLine());
            
            cel = kel - 273.15;

            Console.WriteLine("A TEMPERATURA CONVERTIDA EM GRAUS CELSIUS É " + cel);
        }
    }
}
