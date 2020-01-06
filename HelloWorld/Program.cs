using System;

namespace SI1
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                Console.WriteLine("Hello {0}", arg);
            }
        }
    }
}
