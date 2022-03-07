using System;
using System.Linq;

namespace RemoveDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that removes all duplicates from a list of elements.

            string[] array = Console.ReadLine().Split(',');
            string[] arrayNew = array.Distinct().ToArray();

            Console.WriteLine(String.Join(",", arrayNew));

        }
    }
}
