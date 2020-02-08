using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Distance_Calculator
{
    class Program
    {
        static void Main()
        {
            int stepsMade = int.Parse(Console.ReadLine());
            decimal stepLength = decimal.Parse(Console.ReadLine());
            int metersTarget = int.Parse(Console.ReadLine());

            decimal distanceCoverd = 0;
            for (int i = 1; i <= stepsMade; i++)
            {
                decimal currStep = stepLength;
                if (i % 5 == 0)
                {
                    currStep -= stepLength * 0.3m;
                }
                distanceCoverd += currStep;
            }

            decimal stepInMeters = distanceCoverd / 100;
            decimal percent = (stepInMeters / metersTarget) * 100;
            Console.WriteLine($"You travelled {percent:F2}% of the distance!");
        }
    }
}
