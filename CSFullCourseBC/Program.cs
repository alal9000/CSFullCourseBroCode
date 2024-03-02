namespace CSFullCourseBC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] ford = { "mustang", "f-150", "explorer" };
            //string[] chevy = { "corvette", "camero", "silverado" };
            //string[] toyota = { "corolla", "camry", "rav4" };

            string[,] parkingLot = { { "mustang", "f-150", "explorer" }, 
                                     { "corvette", "camero", "silverado" }, 
                                     { "corolla", "camry", "rav4" } 
                                   };

            parkingLot[0, 2] = "Fusion";
            parkingLot[2, 0] = "Tacoma";

            //foreach (string car in parkingLot)
            //{
            //    Console.WriteLine(car);
            //}

            for (int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i, j] + " ");
                }
                Console.WriteLine();
            }


        }

      

    }
}
