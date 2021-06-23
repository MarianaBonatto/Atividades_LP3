using System;

namespace Exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, tempo;

            Console.WriteLine("DIGITE SUA IDADE : ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE SEU TEMPO DE TRABALHO: ");
            tempo = int.Parse(Console.ReadLine());

            if (((idade >= 65) || (tempo >= 35)) || ((idade >= 60) && (tempo >= 25)))
                Console.WriteLine("VOCÊ JÁ PODE DE APOSENTAR");
            else
                Console.WriteLine("VOCÊ AINDA NÃO PODE SE APOSENTAR");
        }
    }
}
