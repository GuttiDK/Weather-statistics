using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace RainWeatherStatistics
{

    class RainWeatherStatistics
    {

        public static void Main(string[] args)
        {

            // Input
            List<double> list = new List<double>();
            Console.Write("Enter the number of measurement values: ");
            Int16 numbermeasurementvalues = Int16.Parse(Console.ReadLine());
            Console.Clear();
            
            // Process
            for (Int16 i = 0; i < numbermeasurementvalues; i++)
            {
                Console.Write($"{i + 1}. Enter measured value: ");
                list.Add(Convert.ToDouble(Console.ReadLine()));
            }

            // Output
            Console.Clear();
            Console.WriteLine($"Your average is: {list.Average()}");
            Console.WriteLine($"Your max is: {list.Max()}");
            Console.WriteLine($"Your min is: {list.Min()}");

        }
    }
}