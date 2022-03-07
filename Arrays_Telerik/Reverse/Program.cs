using System;
using System.Linq;

namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            var inputArr = input.ToCharArray();

            Array.Reverse(inputArr);

               Console.WriteLine(inputArr);


        }
    }
}
