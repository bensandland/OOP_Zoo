using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public abstract class Amphibian : Animal
    {


        public Amphibian()
        {
            type = GetType().Name;
        }
    }
}