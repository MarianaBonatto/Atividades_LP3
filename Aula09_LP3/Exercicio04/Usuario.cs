using System;

namespace Exercicio04
{
    public class Usuario
    {
        private string nome;
        private string sobrenome;
        private string senha;
        private Postagem [] postagens = new Postagem[3];

        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public string Senha { get => senha; set => senha = value; }
        public Postagem[] Postagens { get => postagens; set => postagens = value; }
       
    }
}