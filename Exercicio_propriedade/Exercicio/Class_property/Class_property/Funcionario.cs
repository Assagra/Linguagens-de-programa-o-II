using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_property
{
    class Funcionario
    {

        private string nome;
        public  string Nome { get => nome; set => nome = value; }

        private int matricula;
        public int Matricula { get => matricula; set => matricula = value; }

        private double salario;
        public double Salario { get => salario; set => salario = value; }


        //Construtor

        public Funcionario()
        {

        }



    }
}
