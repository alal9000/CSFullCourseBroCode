namespace CSFullCourseBC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double x;
            double y;
            double result;

            try
            {

                Console.Write("Enter number 1: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number 2: ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;

                Console.WriteLine("Result: " + result);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by zero");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter only numbers please");
            }
            catch (Exception e)
            {
                Console.WriteLine("something went wrong");
            }
            finally
            {
                Console.WriteLine("Thanks for visiting");
            }

        }

      

    }
}
