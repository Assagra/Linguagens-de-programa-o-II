using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_visibilidade
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa p1 = new Pessoa("ana", 23, 'F');
            Pessoa p2 = new Pessoa("Paula", 35, 'M');
            Pessoa p3 = new Pessoa();


            //p1.setNome("Ana"); 
            //p2.setNome("Paulo");
            //p3.setNome("Lia");

            //p1.setIdade(23);
            //p2.setIdade(35);
            //p3.setIdade(12);

            p1.setSexo('F');
            p2.setSexo('M');
            p3.setSexo('F');

            Console.WriteLine(p1.getNome() + " " + p1.getIdade() + " " + p1.getSexo());
            Console.WriteLine(p2.getNome() + " " + p2.getIdade() + " " + p2.getSexo());
            Console.WriteLine(p3.getNome() + " " + p3.getIdade() + " " + p3.getSexo());

            Console.ReadKey();
        }   
    }
}
