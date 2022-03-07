using System;
using System.Linq;

namespace ConvertDegrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Celsius (°C) times 9/5 plus 32
            //Search how you could split the list of values and then you can iterate over them
            //0 15 30
            //result ot new line

            int[] degrees = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            double result;

            foreach (int degree in degrees)
            {
                result = (degree * 9 / 5) + 32;
                Console.WriteLine(result);
            } 
            

        }
    }
}
