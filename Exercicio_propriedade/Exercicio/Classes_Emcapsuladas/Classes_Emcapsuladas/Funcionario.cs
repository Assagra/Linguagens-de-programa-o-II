using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Emcapsuladas
{
    class Funcionario 
    {

        private string nome;
        private int matricula;
        private double salario;

        //metodo calcula salario 

        public double calculaMedia(Funcionario func1, Funcionario func2, Funcionario func3)
        {

        }


        //metodos SET

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setMatricula(int matricula)
        {
            this.matricula = matricula;
        }

        public void setSalario(double salario)
        {
            this.salario = salario;
        }

        //metodos GET

        public string getNome()
        {
            return this.nome;
        }

        public int getMatricula()
        {
            return this.matricula;
        }

        public double getSalario()
        {
            return this.salario;
        }

        //Construtor

        public Funcionario(string nome, int matricula, double salario)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.salario = salario;
        }

        public Funcionario()
        {

        }

    }
}
