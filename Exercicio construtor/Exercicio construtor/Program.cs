using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_construtor
{
    class Program
    {
        static void Main(string[] args)
        {

            Alunos a1 = new Alunos("ze", 16, "ZeDoPneu@gmail.com");
            Alunos a2 = new Alunos("Ana", "Aninha@terra.com.hd");
            Alunos a3 = new Alunos("Paulo", 17);

            a2.setIdade(15);
            a3.setEmail("Paulo@ig.com.br");

            Console.WriteLine(a1.getNome() + " " + a1.getIdade() + " " + a1.getEmail());
            Console.WriteLine(a2.getNome() + " " + a2.getIdade() + " " + a2.getEmail());
            Console.WriteLine(a3.getNome() + " " + a3.getIdade() + " " + a3.getEmail());

  
  
        }
    }
}
