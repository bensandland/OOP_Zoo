using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Penguin : Bird
    {
        public Penguin()
        {
            name = "Tine";
            species = this.GetType().Name;
            canFly = true;
            GenerateWingspan(76.2, 81.4);
            GenerateWeight(12.1, 25.1);
        }

    }
}