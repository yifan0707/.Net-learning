using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*unchecked
            {
                int willNotThrow = int.MaxValue + 1;
                Console.WriteLine("Will not throw and it will be executed");
            }*/
            checked
            {
                int max = int.MaxValue;
                int willThrow = max + 1;
                Console.WriteLine("This will never being executed!");
            }
            Console.ReadKey();

        }
    }
}
