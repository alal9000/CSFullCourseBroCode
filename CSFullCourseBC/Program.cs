namespace CSFullCourseBC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x; // declaration
            x = 123; // initialization

            int y = 321; // declaration + initization

            int z = x + y;

            int age = 21; // whole integer
            double height = 300.5; // decimal number
            bool alive = false;
            char symbol = '@';
            string name = "Aaron";


            Console.WriteLine("Hello " + name);
            Console.WriteLine("your age is: " + age);
            Console.WriteLine("You height is: " + height + "cm");
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("You symbol is " + symbol);

            string userName = symbol + name;

            Console.WriteLine("Your username is: " + userName);
        }
    }
}
