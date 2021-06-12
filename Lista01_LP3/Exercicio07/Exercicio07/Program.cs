using System;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            float fah = 0, cel = 0;

            Console.WriteLine("Digite uma temperatura em grau fahrenheit : ");
            fah = float.Parse(Console.ReadLine());

            cel = 5 * (fah - 32) / 9;

            Console.WriteLine("A TEMPERATURA CONVERTIDA PARA GRAUS CELSIUS É " + cel);
        }
    }
}
