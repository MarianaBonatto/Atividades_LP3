using System;

namespace Aula05_LP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            int cont = 1;

            while(cont < 5)
            {
                Console.WriteLine("\nO número do contador é : " + cont);
                cont++;
            }

            //Do While
            int cont2 = 1;
            do
            {
                Console.WriteLine("\nO número do contador é : " + cont2);
                cont2++;
            }
            while (cont2 < 5);
            //For
            for (int cont3 = 0; cont3 < 10; cont3++) 
                Console.WriteLine("O contador vale : " + cont3);

            string[,] vetor = new string[2, 3];
            vetor[0, 0] = "A";
            vetor[0, 1] = "B";
            vetor[1, 0] = "C";
            vetor[1, 1] = "D";

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    Console.WriteLine("O elemento da posição (" + i + "," + j + ") é " + vetor[i, j]);

            //Foreach
            int[] elementos = new int[5] { 1, 2, 3, 4, 5 };

            foreach (int x in elementos)
                Console.WriteLine("O valor do elemento é " + x);

            //Break
            int m = 1;

            while(m < 10)
            {
                if (m == 5)
                    break;

                Console.WriteLine(m + ", ");
                m++;
            }

            //Continue
            int a = 1;

            while(a < 10)
            {
                if(a == 5)
                {
                    a++;
                    continue;
                }
                Console.WriteLine(a + ", ");
                a++;
            }
        }
    }
}
