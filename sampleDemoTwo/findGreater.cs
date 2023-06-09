using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleDemoTwo
{
    internal class findGreater
    {
        //Accept two numbers & find the greater number.
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter First Number");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
                Console.WriteLine("First number is Greater");
            else if (b > a)
                Console.WriteLine("Second number is Greater");
            else
                Console.WriteLine("numbers are equal");

        }

    }
}
