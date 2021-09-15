using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now;
            Console.WriteLine(current.ToString("dddd dd, MMMM"));
            Console.WriteLine(current.ToString(""));
        }
    }
}
