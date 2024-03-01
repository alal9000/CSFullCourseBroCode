namespace CSFullCourseBC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string fullname = "Aaron Lal";
            string phoneNumber = "123-456-7890";

            //fullname = fullname.ToUpper();
            //fullname = fullname.ToLower();

            //phoneNumber = phoneNumber.Replace("-", "");

            //string userName = fullname.Insert(0, "Mr.");

            string firstName = fullname.Substring(0, 5);
            string lastName = fullname.Substring(6, 3);

            

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
        }
    }
}
