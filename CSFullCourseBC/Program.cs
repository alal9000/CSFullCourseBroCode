namespace CSFullCourseBC
{
    public class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "Rick";
            human1.age = 65;

            human1.Eat();
            human1.Sleep();
            human1.howOld();

            human2.name = "Morty";
            human2.age = 16;

            human2.Eat();
            human2.Sleep();
            human2.howOld();




        }

    }
    class Human
    {
        public string name;
        public int age;

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }

        public void howOld()
        {
            Console.WriteLine(name + " is " + age + " years old");
        }

    }

      

    
}
