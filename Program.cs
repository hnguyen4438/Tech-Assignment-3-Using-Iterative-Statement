//Name: Hieu Nguyen

using System;

namespace Tech_Assignment__3_Using_Iterative_Statenent
{
    class Program
    {
        static void Main(string[] args)
        {
            double CAD = 0, USD;

    //Get the input - CAD incremental value
            Console.WriteLine("Enter a CAD incremental value");

            try
            {
                string inputdata = Console.ReadLine();
                int inputvalue = int.Parse(inputdata);
    //Use conditional if/else statement to check the value that user enter
    //If input < 5 or input > 25: try again
                if (inputvalue < 5 || inputvalue > 25)
                {
                    Console.WriteLine("Try again with value between 5 and 25");
                    Console.WriteLine("Press any keys to exit the program");
                    Console.ReadKey(true);
                }
     //If put between 5 to 25, perform calculation until CAD value reach 200
                else
                {
                    Console.WriteLine("{0,-10:C} {1,-10:C}", "CAD", "US$");
                    while (CAD <= 200)
                    {
                        USD = CAD * 0.792367;
                        Console.WriteLine("{0,-10:C} {1,-10:C}", CAD, USD);
                        CAD += inputvalue;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Try again with value between 5 and 25");
                Console.WriteLine("Press any keys to exit the program");
                Console.ReadKey(true);
            }
        }
    }
}
