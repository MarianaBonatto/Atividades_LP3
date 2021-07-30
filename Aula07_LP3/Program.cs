using System;

namespace Aula07_LP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.setNome("Dean");
            p1.setSobrenome("Di-Laurents");
            p1.setIdade(21);
            p1.setAltura(1.80f);
            p1.setPeso(82.0f);

            p1.getNome();
            p1.getSobrenome();
            p1.getIdade();
            p1.getAltura();
            p1.getPeso();
        }
    }
}
