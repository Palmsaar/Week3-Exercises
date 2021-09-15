using System;

namespace WeatherReport_switch_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temp outside (in degrees)?");
            int OutsideTemp = Convert.ToInt32(Console.ReadLine());
            switch (OutsideTemp)
            {
                case var _ when OutsideTemp > 35:
                    Console.WriteLine("Boiling hot");
                    break;
                case var _ when OutsideTemp >= 30 && OutsideTemp < 36:
                    Console.WriteLine("Hot");
                    break;
                case var _ when OutsideTemp >= 20 && OutsideTemp < 30:
                    Console.WriteLine("Nice");
                    break;
                case var _ when OutsideTemp >= 10 && OutsideTemp < 20:
                    Console.WriteLine("Chilly");
                    break;
                case var _ when OutsideTemp >= 0 && OutsideTemp < 10:
                    Console.WriteLine("Cold");
                    break; 
                case <0:
                    Console.WriteLine("Freezing cold");
                    break; 
            }
            Console.ReadLine();
        }
    }
}
