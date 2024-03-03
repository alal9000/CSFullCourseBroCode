namespace CSFullCourseBC
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Human human1 = new Human("Rick", 65);
            //Human human2 = new Human("Morty", 16);

            //human1.Eat();
            //human1.Sleep();
            //human1.howOld();

            //human2.Eat();
            //human2.Sleep();
            //human2.howOld();

            Car car1 = new Car("Ford", "Mustang", 2022, "red");
            Car car2 = new Car("Chevy", "Corvette", 2021, "blue");

            car1.Drive();
            car2.Drive();




        }

    }
    //class Human
    //{
    //    public string name;
    //    public int age;

    //    public Human(string name, int age)
    //    {
    //        this.name = name;
    //        this.age = age;
    //    }

    //    public void Eat()
    //    {
    //        Console.WriteLine(name + " is eating");
    //    }

    //    public void Sleep()
    //    {
    //        Console.WriteLine(name + " is sleeping");
    //    }

    //    public void howOld()
    //    {
    //        Console.WriteLine(name + " is " + age + " years old");
    //    }

    //}

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

        public void Drive()
        {
            Console.WriteLine("You drive the " + make + " " + model);
        }
    }

      

    
}
