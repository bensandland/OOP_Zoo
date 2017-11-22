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

        protected string _name;

        /*
         * Get-setters of variables. (remove either get or set in order to disable getting or setting.) if you want both, change to private.
         */

        public string name { get { return _name; } set { _name = value; } }

        /*
         * Constructor
         */
        public Animal()
        {

        }
    }
}