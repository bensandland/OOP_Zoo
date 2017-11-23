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
            canFly = true;
            wingSpanCM = 100;
            GenerateWeight(1.2, 4.1); // Set weight
        }

    }
}