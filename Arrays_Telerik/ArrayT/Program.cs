using System;
using System.Linq;

namespace ArrayT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a list of numbers separated by a comma and space.
            //Arrange the numbers in descending order.
            //Output all numbers on a single line, separated by a comma and a space.

            int[] numbersArray = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            Array.Sort(numbersArray);
            Array.Reverse(numbersArray);
            Console.Write(String.Join(", ", numbersArray));
            
        }
    }
}