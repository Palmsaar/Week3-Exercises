using System;

namespace Week3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Peale enter your exam results for mathematics (in numbers).");
            int UserMath = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your exam results for chemistry (in numbers).");
            int UserChem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your exam results for biology (in numbers).");
            int UserBio = Convert.ToInt32(Console.ReadLine());
            if (UserMath >= 85 && UserChem >= 90 && UserBio >= 95)
            {
                Console.WriteLine("You can become a doctor!");
            }
            else
            {
                Console.WriteLine("You can not become a doctor!");
            }
            Console.ReadLine();
        }
    }
}
