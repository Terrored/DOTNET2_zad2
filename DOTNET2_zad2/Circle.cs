using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET2_zad2
{
    class Circle:Shape
    {
        public double Radius { get; set; }

        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public override void CalculateArea()
        {
            base.CalculateArea();
            Console.WriteLine(Radius*Radius*Math.PI);
        }

        public override void CalculateCircuit()
        {
            base.CalculateCircuit();
            Console.WriteLine(2*Math.PI*Radius);
        }
    }
}
