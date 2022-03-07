using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arraySort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given an array integers, write a program that moves all of the zeroes to the end of it, while maintaining the relative order of the non-zero elements.

            int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int[] arrayNew = new int[array.Length];
            int index = 0;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>0)
                {
                    arrayNew[index] = array[i];
                    index++;
                }
                else
                {
                    count++;
                }
                
            }
            index = array.Length - count;
            for (int i = array.Length - count; i < array.Length; i++)
            {
                arrayNew[i] = 0;
            }

            Console.WriteLine(String.Join(",",arrayNew));
        }
    }
}
