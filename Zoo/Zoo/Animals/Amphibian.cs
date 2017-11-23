using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public abstract class Amphibian : Animal
    {

        private bool _doesJump;


        public bool doesJump { get { return _doesJump; } set { _doesJump = value; } }

        public Amphibian()
        {
            type = GetType().Name;
        }
    }
}