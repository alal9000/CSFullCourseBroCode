
namespace CSFullCourseBC
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            string[] stringArray = { "1", "2", "3" };

            DisplayElements(intArray);
            DisplayElements(doubleArray);
            DisplayElements(stringArray);


        }
        //public static void DisplayElements(int[] array)
        //{
        //    foreach (int item in array)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    Console.WriteLine();

        //}

        //public static void DisplayElements(double[] array)
        //{
        //    foreach (double item in array)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    Console.WriteLine();

        //}

        //public static void DisplayElements(string[] array)
        //{
        //    foreach (string item in array)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    Console.WriteLine();

        //}

        public static void DisplayElements<Thing>(Thing[] array)
        {
            foreach (Thing item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }


    }


}
