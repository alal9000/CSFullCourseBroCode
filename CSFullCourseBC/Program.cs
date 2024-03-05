
namespace CSFullCourseBC
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(400);

            car.Speed = 10000000;

            Console.WriteLine(car.Speed);

        }

    }

    class Car
    {
        private int speed;

        public int Speed
        {
            get { return speed; } // read
            set // writable
            {
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
                
            }
        }

        public Car(int speed)
        {
            Speed = speed;
        }

    }

}
