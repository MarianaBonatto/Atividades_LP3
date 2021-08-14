﻿using System;

namespace Exercicio02
{
    public class Cliente
    {
        private string nome;
        private string sobrenome;
        private string cpf;
        private Conta conta;
        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getSobrenome()
        {
            return this.sobrenome;
        }
        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }
        public string getCpf()
        {
            return this.cpf;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public Conta getConta()
        {
            return this.conta;
        }
        public void setConta(Conta conta)
        {
            this.conta = conta;
        }
    }
}