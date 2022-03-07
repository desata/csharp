using System;
using System.Linq;

namespace ListSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that checks if a list is already sorted. For a list to be sorted, the next element must NOT be smaller than the previous one.
            //On the first line -you will receive a number N.
            //On the next N lines, you will receive a list of numbers, separated by a comma

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
                string isSort = "";
                for (int element = 0; element < array.Length - 1; element++)
                {
                    if (array[element] <= array[element + 1])
                    {
                        isSort = "true";

                    }
                    else
                    {
                        isSort = "false";
                        break;
                    }
                }

                Console.WriteLine(isSort);
            }


        }
    }
}
