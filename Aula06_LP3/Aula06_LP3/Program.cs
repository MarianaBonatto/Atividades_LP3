using System;

namespace Aula06_LP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicialização do vetor
            string[] alunos = new string[5];
            alunos[0] = "Rhysand";
            alunos[1] = "Kallias";
            alunos[2] = "Azriel";
            alunos[3] = "Cassian";
            alunos[4] = "Helion";

            //Outra forma de inicializar
            string[] aluno = new string[5] { "Feyre", "Vivianne", "Gwyn", "Nestha", "Lucien" };

            //Percorrendo um vetor
            float[] notas = new float[10];
            int i;

            for(i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite a " + (i + 1) + " nota : ");
                notas[i] = float.Parse(Console.ReadLine());
            }
            Console.Write("\n \n Notas : ");

            //Imprimindo elementos de um array
            foreach(float nota in notas)
            {
                Console.Write(nota + " ");
            }

            //Inicializando uma matriz
            string[,] dados_aluno = new string[3, 2];
            dados_aluno[0, 0] = "Rhys";
            dados_aluno[0, 1] = "rhysinho@gmail.com";
            dados_aluno[0, 0] = "Kallias";
            dados_aluno[0, 0] = "kallias@gmail.com";
            dados_aluno[0, 0] = "Az";
            dados_aluno[0, 0] = "az@gmail.com";

            //Outra forma de inicializar a matriz
            string[,] dados = new string[2,2]{ { "Feyre", "feyre@gmail.com"}, { "Mor", "mor@gmail.com"} };

            //Percorrendo a matriz
            string[,] dados2 = new string[3, 4];
            int k = 0, j = 0;

            for(k = 0; k < 3; k++)
            {
                Console.WriteLine("\nLendo informações do " + (k + 1) + "º aluno : ");
                for(j = 0; j < 4; j++)
                {
                    Console.Write("Digite dados[ " + k + ", " + j + "  ] : ");
                    dados2[k, j] = Console.ReadLine();
                }
            }
        }
    }
}
