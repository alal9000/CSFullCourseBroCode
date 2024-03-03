namespace CSFullCourseBC
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.Go();


            Console.WriteLine(bicycle.speed);
            Console.WriteLine(bicycle.wheels);
            bicycle.Go();

            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            boat.Go();

        }

    }
    class Vehicle
    {
        public int speed = 0;

        public void Go()
        {
            Console.WriteLine("This vehicle is moving");
        }
    }

    class Car : Vehicle
    {
        public int wheels = 4;
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
    }




}
