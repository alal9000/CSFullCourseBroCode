
namespace CSFullCourseBC
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string[] food = new string[3];


            //food[0] = "pizza";
            //food[1] = "hamburger";
            //food[2] = "hotdog";
            //food[3] = "fries";

            List<string> food = new List<string>();

            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");

            //Console.WriteLine(food[0]);

            //food.Remove("fries");

            //food.Insert(0, "sushi");

            //Console.WriteLine(food.Count);

            //Console.WriteLine(food.IndexOf("pizza"));

            //Console.WriteLine(food.LastIndexOf("fries"));

            //Console.WriteLine(food.Contains("pizza"));

            //food.Sort();

            //food.Reverse();

            //food.Clear();

            string[] foodArray = food.ToArray();

            foreach (string item in foodArray)
            {
                Console.WriteLine(item);
            }


        }

    }

}
