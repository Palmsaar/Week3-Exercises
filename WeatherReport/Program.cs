using System;

namespace WeatherReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temp outside (in degrees)?");
            int OutsideTemp = Convert.ToInt32(Console.ReadLine());
            if (OutsideTemp > 35)
            {
                Console.WriteLine("Boiling hot");
            }
            else if (OutsideTemp >= 30 && OutsideTemp < 36)
            {
                Console.WriteLine("Hot");
            }
            else if (OutsideTemp >= 20 && OutsideTemp < 30)
            {
                Console.WriteLine("Nice");
            }
            else if (OutsideTemp >= 10 && OutsideTemp < 20)
            {
                Console.WriteLine("Chilly");
            }
            else if (OutsideTemp >= 0 && OutsideTemp < 10)
            {
                Console.WriteLine("Cold");
            }
            else 
            {
                Console.WriteLine("Freezing cold");
            }
            Console.ReadLine();
        }
    }
}
