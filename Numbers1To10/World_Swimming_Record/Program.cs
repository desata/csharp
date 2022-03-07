﻿using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double totalTime = distance * time;
            double speed = Math.Floor(distance / 15);
            double addTime = speed * 12.5;
            double totalIvan = totalTime + addTime;

            if (record - totalIvan > 0)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalIvan:F2} seconds.");
            }
            else
            {
                double diff = totalIvan - record;
                Console.WriteLine($"No, he failed! He was {diff:F2} seconds slower.");
            }

        }
    }
}
/*
Иван решава да подобри Световния рекорд по плуване на дълги разстояния. На конзолата се въвежда рекордът в секунди, 
който Иван трябва да подобри, разстоянието в метри, което трябва да преплува и времето в секунди,
за което плува разстояние от 1 м. 
Да се напише програма, която изчислява дали се е справил със задачата, 
като се има предвид, че: съпротивлението на водата го забавя на всеки 15 м. с 12.5 секунди.
Когато се изчислява колко пъти Иванчо ще се забави,
в резултат на съпротивлението на водата, резултатът трябва да се закръгли надолу до най-близкото цяло число.
Да се изчисли времето в секунди, за което Иванчо ще преплува разстоянието и разликата спрямо Световния рекорд. 
Вход
От конзолата се четат 3 реда:
1.Рекордът в секунди – реално число в интервала [0.00 … 100000.00]
2.Разстоянието в метри – реално число в интервала [0.00 … 100000.00]
3.Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала [0.00 … 1000.00]
Изход
Отпечатването на конзолата зависи от резултата:
•	Ако Иван е подобрил Световния рекорд (времето му е по-малко от рекорда) отпечатваме:
o   " Yes, he succeeded! The new world record is {времето на Иван} seconds."
•	Ако НЕ е подобрил рекорда (времето му е по-голямо или равно на рекорда) отпечатваме:
o   "No, he failed! He was {недостигащите секунди} seconds slower."
*/