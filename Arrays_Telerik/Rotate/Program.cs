using System;
using System.Linq;

namespace Rotate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that rotates a list several times (the first element becomes last).
            //On the first line you will receive the list of numbers.
            //On the second line you will receive N

            int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int temp = 0;

            for (int i = 0; i < n; i++)
            {
                temp = array[0];

                for (int j = 0; j < array.Length-1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Length - 1] = temp;
            }
            Console.WriteLine(String.Join(",",array));
            
        }
    }
}
