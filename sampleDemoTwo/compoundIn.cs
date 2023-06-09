using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a  program to enter P, T, R and calculate Compound Interest
namespace sampleDemoTwo
{
    internal class compoundIn
    {
        static void Main(string[] args)
        {
            double p, t, r, interest, amount;

            Console.WriteLine("Enter Principal amount");
            p= Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter Number of years");
            t = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Rate of intrest");
            r = Convert.ToInt32(Console.ReadLine());

            amount = p * Math.Pow((1 + r / 100), t);

            //total = Amount * Math.Pow((1 + interestRate / annualCompound),
            //                             (annualCompound * t));

            interest = amount - p;
            Console.WriteLine($"compound intrest is {interest}");
        }
    }
}
