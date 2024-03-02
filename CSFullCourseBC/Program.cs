namespace CSFullCourseBC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Aaron";
            int age = 21;

            singHappyBirthday(name, age);


        }

        static void singHappyBirthday(string birthdayBoy, int yearsOld)
        {
            Console.WriteLine("Happy birthday to you");
            Console.WriteLine("Happy birthday to you");
            Console.WriteLine("Happy birthday dear " + birthdayBoy);
            Console.WriteLine("You are " + yearsOld + " years old");
            Console.WriteLine("Happy birthday to you");
            Console.WriteLine();
        }
    }
}
