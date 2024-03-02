namespace CSFullCourseBC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "BMW", "Mustang", "Corvette" };


            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i]);
            //}

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

        }
    }
}
