using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Program
    {
        static Zoo zoo = Singleton.Instance.zoo;
        static void Main(string[] args)
        {
            zoo.AddAnimal(new Elephant());
            Menu menu = new Menu();
            /* Hold alt (console) menu relateret arbejde inde 
             * i denne class eller i en menu class.
             * På den måde kan vi let porte det over til et
             * hvilket som helst framework såsom:
             * Forms, WPF, ASP.net etc.
             */

            switch (menu.MainMenu())
            {
                case 1:
                    // Call function to list all animals
                    break;
                case 2:
                    // Call function to list by type
                    break;
                case 3:
                    // Call function to list by name
                    break;
            }
            Console.ReadKey();
        }
    }
}
