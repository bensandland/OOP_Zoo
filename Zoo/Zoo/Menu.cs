using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Menu : IMenu
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

        private void Title(string title)
        {
            Console.WriteLine("*****" + title + "*****");
        }

        public int MainMenu()
        {
            // MainMenu
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Title("Main Menu");
            Print("1. List all animals");
            Print("2. List all animals by type");
            Print("3. List all animals by name");
            Console.ResetColor();

            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        public string Request(string parameter)
        {
            Console.WriteLine(parameter);
            string input = Console.ReadLine();
            return input;
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
    }
}
