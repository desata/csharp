﻿using System;

namespace Numbers1To10
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());


            int aquarium = (lenght * width * height);
            double totalLiters = aquarium * 0.001;
            double percent100 = percent*0.01;
            double total = totalLiters*(1-percent100);

/*          Console.WriteLine(totalB);
            Console.WriteLine(totalO);
            Console.WriteLine(totalBe);
            Console.WriteLine(totalS);*/
            Console.WriteLine(total);
        }
    }
}
/*
 * 
За рождения си ден Любомир получил аквариум с формата на паралелепипед. Първоначално прочитаме от конзолата на отделни редове размерите му – дължина, широчина и височина в сантиметри. 
Трябва да се пресметне колко литра вода ще събира аквариума, ако се знае, че определен процент от вместимостта му е заета от пясък, растения, нагревател и помпа. 
Един литър вода се равнява на един кубичен дециметър/ 1л=1 дм3/. 
Да се напише програма, която изчислява литрите вода, която са необходими за напълването на аквариума.
Вход
От конзолата се четат 4 реда:
1.	Дължина в см – цяло число в интервала [10 … 500]
2.	Широчина в см – цяло число в интервала [10 … 300]
3.	Височина в см – цяло число в интервала [10… 200]
4.	Процент  – реално число в интервала [0.000 … 100.000]
Изход
Да се отпечата на конзолата едно число:
•	литрите вода, които ще  събира аквариума.


 */