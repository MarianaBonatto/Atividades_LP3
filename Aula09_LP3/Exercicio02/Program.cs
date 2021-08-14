using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente();
            Cliente c2 = new Cliente();
            Cliente c3 = new Cliente();

            Conta co1 = new Conta();
            Conta co2 = new Conta();
            Conta co3 = new Conta();

            co1.setAgencia("Banco de Velaris");
            co1.setNumero(056060);
            co1.setSaldo(5000000f);

            co2.setAgencia("Banco de Inverno");
            co2.setNumero(065395);
            co2.setSaldo(40000000f);

            co3.setAgencia("Banco de Velaris");
            co3.setNumero(005987);
            co3.setSaldo(10000000.50f);

            c1.setNome("Rhysand");
            c1.setSobrenome("Da Silva");
            c1.setCpf("040.538.096-25");
            c1.setConta(co1);

            c2.setNome("Kallias");
            c2.setSobrenome("Frost");
            c2.setCpf("538096258-07");
            c2.setConta(co2);

            c3.setNome("Azriel");
            c3.setSobrenome("Pinto");
            c3.setCpf("059634852-17");
            c3.setConta(co3);

            Console.WriteLine("===== Cliente 01 ===== \nNome : " + c1.getNome() + "\nSobrenome : " + c1.getSobrenome() + "\nCPF : " + c1.getCpf() + "\nConta : \nAgência : " + c1.getConta().getAgencia() + "\nNúmero : " + c1.getConta().getNumero() + "\nSaldo : " + c1.getConta().getSaldo());
            Console.WriteLine("\n===== Cliente 02 ===== \nNome : " + c2.getNome() + "\nSobrenome : " + c2.getSobrenome() + "\nCPF : " + c2.getCpf() + "\nConta : \nAgência : " + c2.getConta().getAgencia() + "\nNúmero : " + c2.getConta().getNumero() + "\nSaldo : " + c2.getConta().getSaldo());
            Console.WriteLine("\n===== Cliente 03 ===== \nNome : " + c3.getNome() + "\nSobrenome : " + c3.getSobrenome() + "\nCPF : " + c3.getCpf() + "\nConta : \nAgência : " + c3.getConta().getAgencia() + "\nNúmero : " + c3.getConta().getNumero() + "\nSaldo : " + c3.getConta().getSaldo());
        }
    }
}
