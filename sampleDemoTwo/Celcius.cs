using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to enter temperature in °Celsius and convert it into °Fahrenheit.
namespace sampleDemoTwo
{
    internal class Celcius
    {
        static void Main(string[] args)
        {
            float temp, fahrenheit;

            Console.WriteLine("enter temperature in Celsius ");
            temp= Convert.ToInt32(Console.ReadLine());


            fahrenheit = (temp * 9 / 5) + 32;

            Console.WriteLine($"temperature is = {temp} and in Fahrenheit = {fahrenheit}");


            //9.Write a program to enter temperature in Fahrenheit(°F) and convert it into Celsius(°C)

            float temp1, celsius;

            Console.WriteLine("enter temperature in Fahrenheit ");
            temp1 = Convert.ToInt32(Console.ReadLine());

            celsius = (temp1 - 32) * 5 / 9;
            Console.WriteLine($"temperature in Fahrenheit(°F) = {temp1} and convert it into Celsius(°C) = {celsius}");
        }
    }
}
