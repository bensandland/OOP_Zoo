using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Shark : Fish
    {
        public Shark()
        {
            name = "Week";
            species = this.GetType().Name;
            hasScale = false;
            hasGills = true;
            carnivorous = true;
            GenerateWeight(385, 635);
        }

        public Shark()
        {
            throw new System.NotImplementedException();
        }
    }
}