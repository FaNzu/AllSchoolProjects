using AllProjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AllProjects
{
    public class Age
    {
        public void chooseAge()
        {
            string name = "ukendt";
            int age = 0;
            Console.Write("Hvad er dit navn: ");
                name = Console.ReadLine();
                Console.Write("Hvad er din alder: ");
                age = int.Parse(Console.ReadLine());
                if (age >= 0 && age <=12)
                {
                    Console.WriteLine($"{name} er {age} år gammel og er baby");
                }
                else if (age >= 13 && age <= 19)
                {
                    Console.WriteLine($"{name} er {age} år gammel og er teenager");
                }
                else if (age >= 20 && age <= 25)
                {
                    Console.WriteLine($"{name} er {age} år gammel og studere");
                }
                else if (age >= 26 && age <= 67)
                {
                    Console.WriteLine($"{name} er {age} år gammel og arbejder");
                }
                else if (age > 67)
                {
                    Console.WriteLine($"{name} er {age} år gammel og er gammel");
                }
        }
    }
}
