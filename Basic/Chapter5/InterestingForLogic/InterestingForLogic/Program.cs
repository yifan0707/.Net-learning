using System;

namespace InterestingForLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).MultiConditionFor();
        }

        void MultiConditionFor()
        {
            for (String line = Console.ReadLine(); line != ""; line = Console.ReadLine())
            {
                Console.WriteLine("Inputed line is: " + line);
            }

            //interesting for loop
            for(int i = 0, j = 10; i <= j; i++, j--)
            {
                //.....
            }
        }
    }
}
