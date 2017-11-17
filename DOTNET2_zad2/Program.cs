using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET2_zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square1= new Square(4.5);
            square1.CalculateArea();
            square1.CalculateCircuit();

            Circle circle1 =new Circle(3);
            circle1.CalculateArea();
            circle1.CalculateCircuit();

            Triangle triangle1 = new Triangle(3, 4, 5);
            triangle1.CalculateArea();
            triangle1.CalculateCircuit();

            Console.ReadKey();
        }
    }
}
