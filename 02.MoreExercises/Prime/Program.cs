﻿using System;
public class Exercise34
{
    public static void Main()
    {
        int num, i, ctr, stno;

        Console.Write("\n\n");
        Console.Write("Find the prime numbers within a range of numbers:\n");
        Console.Write("---------------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input starting number of range: ");
        stno = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input ending number of range : ");
        //enno = Convert.ToInt32(Console.ReadLine());
        Console.Write("The prime numbers between {0}  are : \n", stno);

        for (num = stno; num <= 1000; num++)
        {
            ctr = 0;

            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    ctr++;
                    break;
                }
            }

            if (ctr == 0 && num != 1)
                Console.Write("{0} ", num);
        }
        Console.Write("\n");
    }
}