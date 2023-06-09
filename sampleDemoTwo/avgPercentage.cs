using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program to enter marks of five subjects and calculate total, average and percentage
namespace sampleDemoTwo
{
    internal class avgPercentage
    {
        static void Main(string[] args)
        {
            double s1, s2, s3, s4, s5, total, avg, perc;
            Console.WriteLine("Enter Math subject mark");
            s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Bio subject mark");
            s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Marathi subject mark");
            s3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter English subject mark");
            s4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter CS subject mark");
            s5 = Convert.ToInt32(Console.ReadLine());

            total = s1 + s2 + s3 + s4 + s5;
            Console.WriteLine($"total mark of student is {total}");


            avg = total / 5;
            perc = (total / 500) * 100;

           

            Console.WriteLine($"average mark of student is {avg}");
            Console.WriteLine($"Percentage of student is {perc}");
        }
    }
}
