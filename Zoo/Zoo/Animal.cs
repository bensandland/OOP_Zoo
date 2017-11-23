using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public abstract class Animal
    {
        /*
         * Internal values.
         */
        private string _name = "None specified"; //Johnny?Frank?
        private string _type = "None specified"; //Mammal? Fish? Vertebrate? Bird? Reptile?
        private string _species = "None specified"; //Tiger?Parrot?
        private string _color = "None specified";
        private double _weight = 0.0;

        /*
         * Get-setters of variables. (remove either get or set in order to disable getting or setting.) if you want both, change to private.
         */
        public string name { get { return _name; } set { _name = value; } }
        public string species { get { return _species; } set { _species = value; } }
        public string type { get { return _type; } set { _type = value; } }
        public double weightG { get { return _weight * 1000; } set { _weight = value / 1000; } } // To convert to gram
        public double weightKG { get { return _weight; } set { _weight = value; } }

        /*
         * Constructor
         */
        public Animal()
        {

        }

        public virtual void GenerateWeight(double minWeight, double maxWeight)
        {
            Random random = new Random();
            double weight = random.NextDouble() * (maxWeight - minWeight) + minWeight;
        }
    }
}