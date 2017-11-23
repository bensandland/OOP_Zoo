using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Tiger : Mammal
    {
        public Tiger()
        {
            name = "King Bangalash";
            species = GetType().Name;
        }
    }
}