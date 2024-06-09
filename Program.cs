using System;
using System.Diagnostics;

namespace EvaluateGrades_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first grade: ");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second grade: ");
            double second = Convert.ToDouble(Console.ReadLine());

            double aveRage = average(first, second);
            Console.WriteLine($"The average grade is {aveRage}");

            string mark = equivalent(aveRage);
            Console.WriteLine($"Remark: {mark}");

        }

        public static double average(double first, double second)
        {
            double ave = 0;

            ave = (first + second) / 2;

            return ave;
        }

        
        public static string equivalent(double aveRage)
        {
            string mark = "";

            if (aveRage > 90 && aveRage < 100)
            {
                mark = "EXCELLENT";
            }
            else if (aveRage > 80 && aveRage <= 90)
            {
                mark = "VERY GOOD";
            }
            else if (aveRage > 70 && aveRage <= 80)
            {
                mark = "GOOD";
            }
            else if (aveRage > 50 && aveRage <= 70)
            {
                mark = "FAIR";
            }
            else if (aveRage >= 0 && aveRage <= 50)
            {
                mark = "FAILED";
            }
            else
            {
                mark = "Invalid Input.";
            }

            return mark;
        }
    }
}
