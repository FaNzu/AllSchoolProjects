using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllProjects
{
    public class Menuproject
    {
        public void Menu()
        {
            Console.WriteLine("Min fantastiske menu \n\n1. Gør dit\n3. Gør dat\n2. alder bestemmelse\n\n (tryk på 1, 2 eller 3)");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("gør dit");
            }
            else if (input == "2")
            {
                Console.WriteLine("gør dit");
            }
            else if (input == "3")
            {
                Age age = new Age();
                age.chooseAge();
            }
        }
    }
}
