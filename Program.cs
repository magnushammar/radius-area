// Calculate the area of a circle.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radius_area
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, area;
            Console.Write("Enter the radius of the circle: ");
            radius = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * radius * radius;
            Console.WriteLine("The area of the circle is: {0}", area);
            Console.ReadLine();
        }
    }
}
