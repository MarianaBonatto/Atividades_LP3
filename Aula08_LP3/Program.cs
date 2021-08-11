using System;

namespace Aula08_LP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Casa c1 = new Casa();
            Casa c2 = new Casa();

            c1.area = 1.28f;
            c1.altura = 200.68f;
            c1.preco = 2000000;

            Console.WriteLine("=====Casa 01=====" + "\nÁrea : " + c1.area + "\nAltura : " + c1.altura + "\nPreço : " + c1.preco);

            c2.area = 200.65f;
            c2.altura = 600.84f;
            c2.preco = 400000;

            Console.WriteLine("=====Casa 02=====" + "\nÁrea : " + c2.area + "\nAltura : " + c2.altura + "\nPreço : " + c2.preco);
        }
    }
}
