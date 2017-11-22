using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Animal
    {
        /*
         * Internal values.
         */
        private string _name = "None specified"; //Johnny?Frank?
        private string _type = "None specified"; //Mammal? Fish? Vertebrate? Bird? Reptile?
        private string _species = "None specified"; //Tiger?Parrot?

        /*
         * Get-setters of variables. (remove either get or set in order to disable getting or setting.) if you want both, change to private.
         */
        public string name { get { return _name; } set { _name = value; } }
        public string species { get { return _species; } set { _species = value; } }
        public string type { get { return _type; } set { _type = value; } }
        /*
         * Constructor
         */
        public Animal()
        {

        }


    }
}