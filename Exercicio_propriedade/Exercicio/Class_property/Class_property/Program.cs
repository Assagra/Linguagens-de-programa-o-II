using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_property
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double soma = 0;
            double media = 0;

            Funcionario[] funcionarios = new Funcionario[4];

            Funcionario func1 = new Funcionario();
            Funcionario func2 = new Funcionario();
            Funcionario func3 = new Funcionario();
            Funcionario func4 = new Funcionario();


            funcionarios[0] = func1;
            funcionarios[1] = func2;
            funcionarios[2] = func3;
            funcionarios[3] = func4;

            funcionarios[0].Nome = "Carlos";
            funcionarios[1].Nome = "Paulo";
            funcionarios[2].Nome = "Lucas";
            funcionarios[3].Nome = "Ana";

            funcionarios[0].Matricula = 10001;
            funcionarios[1].Matricula = 10002;
            funcionarios[2].Matricula = 10003;
            funcionarios[3].Matricula = 10004;

            funcionarios[0].Salario = 5000.00;
            funcionarios[1].Salario = 2500.00;
            funcionarios[2].Salario = 9000.50;
            funcionarios[3].Salario = 2000.00;

            for(i = 0; i < 4; i++)
            {
                soma = funcionarios[i].Salario + soma;

                if( (i + 1) == 4)
                {
                    media = soma / 4;
                    break;
                }
            }

            Console.WriteLine("|||||||||Salarios acima da media|||||||| \n");

            for(i = 0; i < 4; i++)
            {

                if( funcionarios[i].Salario >= media)
                {
                    Console.WriteLine(funcionarios[i].Nome + " " + funcionarios[i].Matricula);
                }
                else
                {
                    continue;
                }

            }

            Console.ReadKey();

        }
    }
}
