
namespace CSFullCourseBC
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Civic");

            Console.WriteLine(car.Model);

        }

    }

    class Car
    {
        //string model;

        //public string Model
        //{
        //    get { return model; }
        //    set { model = value; }
        //}

        public string Model { get; set; } // this is the same as the above comment

        public Car(string model)
        {
            this.Model = model;
        }

    }

}
