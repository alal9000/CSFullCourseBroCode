﻿

namespace CSFullCourseBC
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mustang", "red");

            Car car2 = Copy(car1);


            Console.WriteLine(car2.color + " " + car2.model);


        }

        static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
        }


    }

    class Car
    {
        public string model;
        public string color;

        public Car(string model, string color)
        {
            this.model = model;
            this.color = color;

        }
    }






}
