using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Colecao
{
    class Funcionarios
    {

        private string nome;
        private int matricula;
        private string cpf;


        //construtor

        public Funcionarios(string nome, int matricula, string cpf)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.cpf = cpf;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setMatricula(int matricula)
        {
            this.matricula = matricula;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string getNome()
        {
            return this.nome;
        }

        public int getMatricula()
        {
            return this.matricula;
        }

        public string getCpf()
        {
            return this.cpf;
        }

        

    }
}
