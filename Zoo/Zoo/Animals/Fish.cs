﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public abstract class Fish : Animal
    {
        private bool _hasScale;
        private bool _hasGills;
        private bool _carnivorous; // Eats meat or not?

        public bool hasScale { get { return _hasScale; } set { _hasScale = value; } }
        public bool hasGills { get { return _hasGills; } set { _hasGills = value; } }
        public bool carnivorous { get { return _carnivorous; } set { _carnivorous = value; } }


        public Fish()
        {
            type = GetType().Name;
        }
    }
}