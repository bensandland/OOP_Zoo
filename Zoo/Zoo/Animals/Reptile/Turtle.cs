using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Turtle : Reptile
    {
        public Turtle()
        {
            name = "Charles";
            species = this.GetType().Name;
            canSwim = true;
            isDeadly = false;
            isColdBlooded = true;
            GenerateWeight(250, 700);
        }

    }
}