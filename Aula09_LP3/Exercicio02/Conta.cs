using System;

namespace Exercicio02
{
    public class Conta
    {
        private string agencia;
        private int numero;
        private float saldo;

        public string getAgencia()
        {
            return this.agencia;
        }
        public void setAgencia(string agencia)
        {
            this.agencia = agencia;
        }
        public int getNumero()
        {
            return this.numero;
        }
        public void setNumero(int numero)
        {
            this.numero = numero;
        }
        public float getSaldo()
        {
            return this.saldo;
        }
        public void setSaldo(float saldo)
        {
            this.saldo = saldo;
        }
    }
}