using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Fish : Animal
    {


        public Fish()
        {
            type = GetType().Name;
        }
    }
}