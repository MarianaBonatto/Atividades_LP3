using System;

namespace Aula04_LP3
{
    class Program
    {
        static void Main(string[] args)
        {
            double prova1 = 8.0;
            double prova2 = 8.0;
            double media = 0.0;
            string desempenho;

            media = (prova1 + prova2) / 2;

            if (media <= 5)
                desempenho = "INSATISFATÓRIO";
            else if (media > 5 && media <= 7)
                desempenho = "REGULAR";
            else if (media > 7 && media <= 8.5)
                desempenho = "BOM";
            else
                desempenho = "ÓTIMO";

            Console.WriteLine("O DESEMPENHO DO ALUNO FOI " + desempenho);

            string opcao = "não";

            switch (opcao)
            {
                case "sim":
                    Console.WriteLine("Você escolheu a opção SIM");
                    break;
                case "não":
                case "talvez":
                    Console.WriteLine("Você não escolheu a opção SIM");
                    break;
                default:
                    Console.WriteLine("A opção digitada é inválida");
                    break;
            }
        }
    }
}
