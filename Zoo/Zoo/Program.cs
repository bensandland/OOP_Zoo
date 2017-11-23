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
            switch (menu.Start())
            {
                case "1":
                    menu.Print("Animals in zoo", ConsoleColor.Green);
                    menu.ListAnimals(zoo.animals);
                    Console.ReadKey();
                    break;
                case "2":
                    menu.Print("Animals by type", ConsoleColor.Green);
                    //
                    Console.ReadKey();
                    break;
                case "3":
                    menu.Print("Animals by name", ConsoleColor.Green);
                    Console.ReadKey();
                    break;
            }
            Console.ReadKey();
        }
    }
}
