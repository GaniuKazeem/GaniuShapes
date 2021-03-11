using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaniuShapes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Shape>();

            list.Add(new Triangle(3.6, 6.4));
            list.Add(new Rectangle(12.4, 10.2));
            list.Add(new Circle(8.8));




            Console.WriteLine($"Area of Triangle: {list[0].CalculateSurface()}");
            Console.WriteLine($"Area of Rectangle: {list[1].CalculateSurface()}");
            Console.WriteLine($"Area of Circle: {list[2].CalculateSurface()}");
            Console.ReadKey();
        }
    }
}
