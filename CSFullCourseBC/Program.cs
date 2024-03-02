﻿namespace CSFullCourseBC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double total = CheckOut(3.99, 5.75, 15, 1.00, 10.25);

            Console.WriteLine(total);


        }

        static double CheckOut(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }
            
            return total;
        }

    }
}
