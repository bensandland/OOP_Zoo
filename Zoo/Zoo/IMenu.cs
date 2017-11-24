using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    interface IMenu
    {
        string Request(string Request);

        int MainMenu();

        void ListAnimals(List<Animal> animals);
    }
}
