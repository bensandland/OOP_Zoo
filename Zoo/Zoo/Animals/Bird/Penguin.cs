﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Penguin : Bird
    {
        public Penguin()
        {
            name = "Tine"; // skal fjernes og sættes når man laver Penguin, så man ikke ender ud med 200 Pingviner som hedder Tine <3.
            species = GetType().Name;
            canFly = true;
            GenerateWingspan(76.2, 81.4);
            GenerateWeight(12.1, 25.1);
        }

    }
}