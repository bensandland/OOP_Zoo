using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Flamingo : Bird
    {
        public Flamingo()
        {
            name = "Marty McFly";
            species = GetType().Name;
            canFly = true;
            GenerateWingspan(89.8, 100.4);
            GenerateWeight(1.2, 4.1); // Set weight
        }

    }
}