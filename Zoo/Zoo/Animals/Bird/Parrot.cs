using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Parrot : Bird
    {
        public Parrot()
        {
            name = "Parrot Hilton";
            species = this.GetType().Name;
            canFly = true;
            GenerateWingspan(65.1, 74.3);
            GenerateWeight(1.8, 4.1);
        }
    }
}