using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Postagem p1 = new Postagem();
            Postagem p2 = new Postagem();
            Postagem p3 = new Postagem();

            p1.Titulo = "Velaris a noite";
            p1.Data = "13/08/2021";
            p1.Conteudo = "Como é a cidade da luz estelar a noite";
            p1.Visitas = 208;

            p2.Titulo = "Corte outonal";
            p2.Data = "13/08/2021";
            p2.Conteudo = "Como funciona a forma de governo na corte outonal";
            p2.Visitas = 146;

            p3.Titulo = "Corte invernal";
            p3.Data = "13/08/2021";
            p3.Conteudo = "O baby frost se aproxima, acompanhe a gestação do filho de Viviane e Kllias, Grão Senhores da corte invernal";
            p3.Visitas = 578;

            Usuario u1 = new Usuario();

            u1.Nome = "Jornal das cortes";
            u1.Sobrenome = "Por Mariana Bonatto";
            u1.Senha = "feysand>>>";
            u1.Postagens[0] = p1;
            u1.Postagens[1] = p2;
            u1.Postagens[2] = p3;
            

            Console.WriteLine("===== Usuário ===== \nNome : " + u1.Nome + "\nSobrenome : " + u1.Sobrenome + "\nSenha : " + u1.Senha );
            Console.WriteLine("\n===== Publicações =====");
            for (int i = 0; i < 3; ++i)
            {
                Console.WriteLine("Título" + (i+1) + " : " + u1.Postagens[i].Titulo);
                Console.WriteLine("Data" + (i + 1) + " : " + u1.Postagens[i].Data);
                Console.WriteLine("Conteúdo" + (i + 1) + " : " + u1.Postagens[i].Conteudo);
                Console.WriteLine("Visitas" + (i + 1) + " : " + u1.Postagens[i].Visitas);
                Console.WriteLine("\n");
            }
           
        }
    }
}
