﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Zoo
    {
        //List all private variables
        private List<Animal> _animals = new List<Animal>();

        //List all get-setters.
        public List<Animal> animals { get { return _animals; } set { _animals = value; } }        

        public Zoo()
        {
            animals.Add(new Tiger()); // Yay my science worked. The cosine, of your route, divided by... #Heimerdonger
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public Animal[] GetAnimalsByType(string passedType)
        {
            return animals.Where(animal => animal.type == passedType).ToArray();
        }

        public Animal[] GetAnimalsByName(string passedName)
        {
            return animals.Where(animal => animal.name == passedName).ToArray();
        }

        public Animal[] GetAnimalsBySpecies(string passedSpecies)
        {
            return animals.Where(animal => animal.species == passedSpecies).ToArray();
        }
    }
}