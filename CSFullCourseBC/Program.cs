﻿namespace CSFullCourseBC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] cars = { "BMW", "Mustang", "Corvette" };

            string[] cars = new string[3];

            cars[0] = "Tesla";
            cars[1] = "Mustang";
            cars[2] = "Corvette";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

        }
    }
}
