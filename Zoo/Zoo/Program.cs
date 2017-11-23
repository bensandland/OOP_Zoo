using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            /* Hold alt (console) menu relateret arbejde inde 
             * i denne class eller i en menu class.
             * På den måde kan vi let porte det over til et
             * hvilket som helst framework såsom:
             * Forms, WPF, ASP.net etc.
             */
            zoo.AddAnimal(new Tiger()
            {
                weightKG = Tiger
            });

            Console.ReadKey();
        }
    }
}
