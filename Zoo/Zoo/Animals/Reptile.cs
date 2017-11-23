using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Reptile : Animal
    {

        private bool _canSwim;
        private bool _isDeadly;
        private bool _isColdBlooded;

        public bool canSwim { get { return _canSwim; } set { _canSwim = value; } }
        public bool isDeadly { get { return _isDeadly; } set { _isDeadly = value; } }
        public bool isColdBlooded { get { return _isColdBlooded; } set { _isColdBlooded = value; } }


        public Reptile()
        {
            type = GetType().Name;
        }
    }
}