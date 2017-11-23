using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Singleton : Zoo
    {
        private static Singleton instance;

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        private Zoo _zoo = new Zoo();
        public Zoo zoo { get { return _zoo; } set { _zoo = value; } }

    }
}
