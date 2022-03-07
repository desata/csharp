using System;
using System.Linq;

namespace Combine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads two lists of numbers and combines them by alternatingly taking elements:

            int[] arrOne = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int[] arrTwo = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int[] arrCombined = new int[arrOne.Length + arrTwo.Length];

            int step = 0;

            for (int i = 0; i < arrOne.Length; i++)
            {
                arrCombined[step] = arrOne[i];
                step++;
                arrCombined[step] = arrTwo[i];
                step++;
            }
            Console.WriteLine(String.Join(",", arrCombined));

        }
    }
}
