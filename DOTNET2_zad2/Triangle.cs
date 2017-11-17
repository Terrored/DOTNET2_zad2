using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET2_zad2
{
    class Triangle:Shape
    {
        public double  Base { get; set; }
        public double Leg { get; set; }

        public double Leg2 { get; set; }

       

        public Triangle(double Base, double Leg,double Leg2)
        {
            if (Base + Leg > Leg2 && Base + Leg2 > Leg && Leg + Leg2 > Base)
            {
                this.Base = Base;
                this.Leg = Leg;
                this.Leg2 = Leg2;
            }else Console.WriteLine("Nie można utworzyć trójkąta z tych boków.");
        }

        public override void CalculateArea()
        {
            base.CalculateArea();
            double p = 0.5 * (Base + Leg2 + Leg);
            Console.WriteLine(Math.Sqrt(p*(p-Base)*(p-Leg)*(p-Leg2)));
        }

        public override void CalculateCircuit()
        {
            base.CalculateCircuit();
            Console.WriteLine(Base + Leg + Leg2);
        }
    }
}
