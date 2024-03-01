namespace CSFullCourseBC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Whats the temperature outside?");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("Its warm outside");
            }
            else if (temp <= -50 || temp >= 50)
            {
                Console.WriteLine("Do not go outside");
            }

        }
    }
}
