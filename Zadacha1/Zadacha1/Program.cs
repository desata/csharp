using System;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mol[ vyvedete quslo: ");
            int number = int.Parse(Console.ReadLine());
            int square = number * number;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Square of " + number + " is " + square);
        }
    }
}
