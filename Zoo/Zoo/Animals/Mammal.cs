using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public abstract class Mammal : Animal
    {

        public Mammal()
        {
            type = GetType().Name;
        }
    }
}