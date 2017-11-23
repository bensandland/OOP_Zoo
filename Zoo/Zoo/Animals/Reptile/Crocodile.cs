using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Crocodile : Reptile
    {
        public Crocodile()
        {
            species = this.GetType().Name;
            name = "Dundee";
            canSwim = true;
            isDeadly = true;
            isColdBlooded = true;
            GenerateWeight(400, 1000);
        }

    }
}