using System;
using System.Collections.Generic;
using System.Linq;

namespace BelowandAboveAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that calculates the average of a list of numbers.
            //Display the average, all the numbers below the average, and all the numbers above the average.
            //Maintain the relative order of numbers.

            //3,-12,0,0,13,5,1,0,-2
            //avg: 0.89
            //below: -12,0,0,0,-2
            //above: 3,13,5,1

            int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            double avg = 0;
            double sum = 0;
            double count = 0;
            List<int> above = new List<int>();
            List<int> below = new List<int>();

            foreach (var num in array)
            {
                sum += num;
                count++;
            }
            avg = sum / count;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < avg)
                {
                    below.Add(array[i]);
                }
                else
                {
                    above.Add(array[i]);
                }
            }
            Console.WriteLine($"avg: {avg:F2}");
            Console.WriteLine($"below: {string.Join(",", below)}");
            Console.WriteLine($"above: {string.Join(",", above)}");
        }
    }
}
