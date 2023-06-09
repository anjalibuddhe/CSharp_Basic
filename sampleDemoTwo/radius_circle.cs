using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleDemoTwo
{
    internal class radius_circle
    {
        static void Main(string[] args)
        {

            //Accept radius of a circle. Display area of a circle.

            double pi = 3.14;
            double r, area;
            Console.WriteLine("Enter radius of circle");
            r = Convert.ToInt32(Console.ReadLine());

            area = pi * r * r;

            Console.WriteLine($"Area of circle is {area}");

        }
    }
}
