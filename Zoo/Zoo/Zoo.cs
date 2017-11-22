using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Zoo
    {
        //List all private variables
        private List<Animal> _animals;

        //List all get-setters.
        public List<Animal> animals { get { return _animals; } set { _animals = value; } }        

        public Zoo()
        {
            animals.Add(new Tiger()); // Yay my science worked. The cosine, of your route, divided by... #Heimerdonger #
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public Animal[] GetAnimalsByType(string param)
        {
            return animals.Where(animal => animal.type == param).ToArray();
        }

        public Animal[] GetAnimalsByName(string param)
        {
            return animals.Where(animal => animal.name == param).ToArray();
        }

        public Animal[] GetAnimalsBySpecies(string param)
        {
            return animals.Where(animal => animal.species == param).ToArray();
        }
    }
}