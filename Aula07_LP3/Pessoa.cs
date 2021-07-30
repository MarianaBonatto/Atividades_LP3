using System;

namespace Aula07_LP3
{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;
        private byte idade;
        private float altura;
        private float peso;

        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nome)
        {
            Console.WriteLine("Nome : " + nome);
        }
        public string getSobrenome()
        {
            return this.sobrenome;
        }
        public void setSobrenome(string sobrenome)
        {
            Console.WriteLine("Sobrenome : " + sobrenome);
        }
        public byte getIdade()
        {
            return this.idade;
        }
        public void setIdade(byte idade)
        {
            Console.WriteLine("Idade : " + idade);
        }
        public float getAltura()
        {
            return this.altura;
        }
        public void setAltura(float altura)
        {
            Console.WriteLine("Altura : " + altura);
        }
        public float getPeso()
        {
            return this.peso;
        }
        public void setPeso(float peso)
        {
            Console.WriteLine("Peso : " + peso);
        }
    }
}