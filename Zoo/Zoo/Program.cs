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
            zoo.AddAnimal(new Elephant() { name = "anton"; });
            Menu menu = new Menu();
            /* Hold alt (console) menu relateret arbejde inde 
             * i denne class eller i en menu class.
             * På den måde kan vi let porte det over til et
             * hvilket som helst framework såsom:
             * Forms, WPF, ASP.net etc.
             */
            switch (menu.MainMenu())
            {
                case 1: //List all animals
                    menu.ListAnimals(zoo.animals);
                    Console.ReadKey();
                    break;
                case 2: // List Animals By Type
                    menu.ListAnimals(zoo.GetAnimalsByType(menu.Request("Please enter a type")));
                    Console.ReadKey();
                    break;
                case 3: // List Animals By Name
                    menu.ListAnimals(zoo.GetAnimalsByName(menu.Request("Please enter a name")));
                    Console.ReadKey();
                    break;
                case 4: // List Animals By Species
                    menu.ListAnimals(zoo.GetAnimalsBySpecies(menu.Request("Please enter a species")));
                    break;
            }
            Console.ReadKey();
        }
    }
}
