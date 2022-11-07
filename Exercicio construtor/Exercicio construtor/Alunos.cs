using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_construtor
{
    class Alunos
    {
        private string nome;
        private int idade;
        private string email;

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }


        public string getNome()
        {
            return this.nome;
        }

        public int getIdade()
        {
            return this.idade;
        }

        public string getEmail()
        {
            return this.email;
        }


        public Alunos(string nome, int idade, string email)
        {
            this.nome = nome;
            this.idade = idade;
            this.email = email;
        }

        public Alunos(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public Alunos(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }

    }
}
