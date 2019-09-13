using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            string firstName;
            string lastName;
            string lemmik_lill;Console.WriteLine("Mis on sinu eesnimi: ");
            string lemmikVärv;
            firstName = Console.ReadLine();
            Console.WriteLine("Mis on sinu perekonnanimi?: ");
            lastName = Console.ReadLine();

            //Console.WriteLine("Nice to meet you, " + firstName + " " + lastName + "!");
            //I am just a comment
            
            
            Console.WriteLine("Mis on sinu lemmikvärv? ");
            lemmikVärv = Console.ReadLine();
            
            
            Console.WriteLine("Mis on sinu lemmik lill? ");
            lemmik_lill = Console.ReadLine();

            Console.WriteLine("Meeldiv kohtuda {0} {1} sinu lemmik värv on {2} ja sinu lemmik lill on {3}", firstName, lastName, lemmikVärv, lemmik_lill);
            
            
            Console.ReadLine();


            



        }
    }
}
