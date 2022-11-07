using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Emcapsuladas
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario[] funcionarios = new Funcionario[4];

            Funcionario func1 = new Funcionario("Carlos", 00001, 2000.00);
            Funcionario func2 = new Funcionario("Pedro", 00002, 1500.00);
            Funcionario func3 = new Funcionario();
            Funcionario func4 = new Funcionario();

            func3.setNome("Lucas");
            func3.setMatricula(00003);
            func3.setSalario(7000.00);

            func4.setNome("Laura");
            func4.setMatricula(00004);
            func4.setSalario(3000.00);

            funcionarios[0] = func1;
            funcionarios[1] = func2;
            funcionarios[2] = func3;
            funcionarios[3] = func4;

        }
    }
}
