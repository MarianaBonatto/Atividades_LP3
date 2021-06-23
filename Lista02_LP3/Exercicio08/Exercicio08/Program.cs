using System;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, peso;
            char sexo;

            Console.WriteLine("Digite F se você for do sexo feminino ou M se você for do sexo masculino");
            sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura : ");
            altura = double.Parse(Console.ReadLine());

            switch(sexo)
            {
                case 'F': 
                    peso = (62.1 * altura) - 44.7;
                    Console.WriteLine("O SEU PESO IDEAL É " + peso);
                    break;

                case 'M':
                    peso = (72.7 * altura) - 58;
                    Console.WriteLine("O SEU PESO IDEAL É " + peso);
                    break;
            }

        }
    }
}
