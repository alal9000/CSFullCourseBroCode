using System.Reflection;

namespace CSFullCourseBC
{
    public class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car("Chevy", "Corvette", 2022, "blue");

            Console.WriteLine(car);

        }



    }

    class Car
    {
        string make;
        string model;
        int year;
        string color;

        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;

        }
        public override string ToString()
        {
            return "this is a " + make + " " + model;
        }
    }






}
