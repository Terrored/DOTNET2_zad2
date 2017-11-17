using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET2_zad2
{
    abstract class Shape
    {
        
        public virtual void CalculateArea()
        {
            Console.Write("Pole wynosi: ");
        }

        public virtual void CalculateCircuit()
        {
            Console.Write("Obwód wynosi: ");
        }
    }
}
