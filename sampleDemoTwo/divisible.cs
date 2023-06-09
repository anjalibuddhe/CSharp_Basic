using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;


//Write a C# program to check whether a number is divisible by 5 and 11 or not
namespace sampleDemoTwo
{
    internal class divisible
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine(" Enter any Number");
            number = Convert.ToInt32(Console.ReadLine());

            if (number % 5 == 0 && number % 11 == 0)
                Console.WriteLine($"{number} is divisible by 5 and 11");
            else
                Console.WriteLine($"{number} is not divisible by 5 and 11");
        }

       
    }
}
