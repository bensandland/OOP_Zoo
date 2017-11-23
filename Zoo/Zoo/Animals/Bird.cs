using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Bird : Animal
    {
        private bool _canFly;
        private double _wingSpan;

        public bool canFly { get { return _canFly; } set { _canFly = value; } }
        public double wingSpanM { get { return _wingSpan; } set { _wingSpan = value; } }
        public double wingSpanCM { get { return _wingSpan * 100; } set { _wingSpan = value / 100; } }

        public Bird()
        {
            type = "Bird";
        }
    }
}