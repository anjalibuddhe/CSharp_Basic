using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleDemoTwo
{
    internal class perimeter
    {
        static void Main(string[] args)
        {
            //Accept length and breadth of a rectangle and find perimeter.

            float lenght, breath;
            float perimeter;

            Console.WriteLine("Enter lenght");
            lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breath");
            breath = Convert.ToInt32(Console.ReadLine());

            perimeter = 2 * (lenght + breath);

            Console.WriteLine($"perimeter of circle {perimeter}");

        }
    }
}
