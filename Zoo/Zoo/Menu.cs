using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Menu
    {
        Zoo zoo = Singleton.Instance.zoo;
       
        /// <summary>
        /// Outputs given string with a color
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="color"></param>        
        public void Print(string msg, ConsoleColor color = ConsoleColor.Gray)
        {
            //zoo.AddAnimal(new Tiger());
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        public string Start()
        {
            Print("Welcome." + "\n" + "Please input the feature you wish to use", ConsoleColor.Yellow);
            Print("1. List all animals in the zoo", ConsoleColor.Yellow);
            Print("2. List all animals by type", ConsoleColor.Yellow);
            Print("3. List all animals by name", ConsoleColor.Yellow);

            string choice = Console.ReadLine();
            return choice;
        }

        public void ListAnimals(List<Animal> animals)
        {
            int i = 0;
            Print("All animals:", ConsoleColor.Green);
            animals.ForEach(delegate (Animal animal)
            {
                i++;
                Print(i + ": " + animal.species, ConsoleColor.Green);
            });
        }

        public void ListAnimalType(List<Animal> animals)
        {
            int i = 0;
            Print("All animal types:", ConsoleColor.Green);
            animals.ForEach(delegate (Animal animal)
            {
                i++;
                Print(i + ": " + animal.type, ConsoleColor.Green);
            });
        }

        public void ListAnimalName(List<Animal> animals)
        {
            int i = 0;
            Print("All animal names:", ConsoleColor.Green);
            animals.ForEach(delegate (Animal animal)
            {
                i++;
                Print(i + ": " + animal.name, ConsoleColor.Green);
            });
        }

        private void MainMenu(string var)
        {
            //MainMenu
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Title("Main Menu");
            Console.WriteLine("1. ");
        }

        private void Title(string title)
        {
            Console.WriteLine("*****" + title + "*****");
        }
    }
}
