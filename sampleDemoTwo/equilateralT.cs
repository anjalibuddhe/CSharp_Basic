using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  //Write a program to calculate area of an equilateral triangle.
namespace sampleDemoTwo
{
    internal class equilateralT
    {
        static void Main(string[] args)
        {
            float side, area, root;
            Console.WriteLine("Enter the Side equilateral triangle");
            side = Convert.ToInt32(Console.ReadLine());

            root = (float)Math.Sqrt(3) / 4;
            area = root * side * side;

            Console.WriteLine($"Area of an equilateral triangle {area}");




        }
    }
}
