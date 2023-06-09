using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program to check whether a year is leap year or not 
namespace sampleDemoTwo
{
    internal class leapYear
    {
        static void Main(string[] args)
        {
            int year;

            Console.WriteLine("enter any year");
            year =Convert.ToInt32(Console.ReadLine());



            if(((year % 4 == 0) && (year % 100 == 0))  || (year % 400 == 0))
                Console.WriteLine($"{year} is leap year");
            else
                Console.WriteLine($"{year} is not leap year");
        }
    }
}
