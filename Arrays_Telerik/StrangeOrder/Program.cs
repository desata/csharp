using System;
using System.Linq;

namespace StrangeOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that orders a list of numbers in the following way:
            //3,-2,1,0,-1,0,-2,1-> - 2,-1,-2,0,0,3,1,1

            int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int[] arrayNew = new int[array.Length];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    arrayNew[index] = array[i];
                    index++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {


                if (array[i] == 0)
                {
                    arrayNew[index] = array[i];
                    index++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {


                if (array[i] > 0)
                {
                    arrayNew[index] = array[i];
                    index++;
                }
            }


            Console.WriteLine(String.Join(",", arrayNew));
        }
    }
}

