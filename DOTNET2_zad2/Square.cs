using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET2_zad2
{
    class Square : Shape
    {

        public double Side { get; set; }

        public Square(double Side)
        {
            this.Side = Side;
        }
        public override void CalculateArea()
        {
            base.CalculateArea();

            Console.WriteLine(Side * Side);
        }

        public override void CalculateCircuit()
        {
            base.CalculateCircuit();
            Console.WriteLine(4*Side);
        }
    }
}
