using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleDemoTwo
{
    internal class triangle
    {
        // Accept two angles of triangle and find third angle.

        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter first angles of triangle");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second angle of triangle");
            b = Convert.ToInt32(Console.ReadLine());

            c = 180 - (a + b);

            Console.WriteLine($"Third angle of traingle is {c}");
        }
    }
}
