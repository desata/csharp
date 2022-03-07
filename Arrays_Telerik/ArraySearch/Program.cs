using System;
using System.Linq;

namespace ArraySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given an array of integers, some elements appear twice and others appear once.
            //Each integer is in the range of [1, N], where N is the number of elements in the array.
            //Find all the integers of[1, N] inclusive that do NOT appear in this array.

            string[] array = Console.ReadLine().Split(',');
            string missing = "";

            for (int i = 1; i < array.Length; i++)
            {
                bool isFound = false;
                foreach (string item in array)
                {
                    if (i == int.Parse(item))
                    {
                        isFound = true;
                        break;
                    }
                }
                if (!isFound)
                {
                    if (missing.Length > 0)
                    {
                        missing += ',';
                    }
                    missing += i;
                }

            }
            Console.Write(missing);
        }
    }
}
