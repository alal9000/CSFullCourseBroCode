namespace CSFullCourseBC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            //if (age > 100)
            //{
            //    Console.WriteLine("You are too old to sign up");
            //}
            //else if (age < 0)
            //{
            //    Console.WriteLine("You havn't been born yet");
            //}
            //else if (age >= 18)
            //{
            //    Console.WriteLine("You are now signed up");
            //}
            //else
            //{
            //    Console.WriteLine("You must be 18+ to sign up");
            //}

            if (name != "")
            {
                Console.WriteLine("Hello " + name);
                
            }
            else
            {
                Console.WriteLine("You did not enter your name");
            }



        }
    }
}
