using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            float cel = 0, fah = 0;

            Console.WriteLine("Digite uma temperatura em graus celsius : ");
            cel = float.Parse(Console.ReadLine());

            fah = cel * 9/5 + 32;

            Console.WriteLine("A TEMPERATURA CONVERTIDA PARA FAHRENHEIT É " + fah);
        }
    }
}
