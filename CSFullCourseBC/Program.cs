﻿namespace CSFullCourseBC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double result;

            Console.WriteLine("Enter in number 1: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter in number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x, y);

            Console.WriteLine(result);


        }

        static double Multiply(double x, double y)
        {
            
            return x * y;
        }
    }
}
