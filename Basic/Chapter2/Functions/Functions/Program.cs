using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Program test = new Program();
            test.OptMethod(3); // will execute first Optmethod
            test.OptMethod(3, "testExtra"); // will execute second Optmethod
            test.CalculateSum();
            Console.ReadKey();
        }

        //optional variables
        //optional variables must be place to the front among all variables
        void OptMethod(int option1, double option2 = 0.0d, String option3 = "test")
        {
            Console.WriteLine($"Option1: {option1}, Option2: {option2}, Option3: {option3}");
        }

        //method overload
        void OptMethod(int option1, String extra, double option2 = 0.0d, String option3 = "test")
        {
            Console.WriteLine($"Option1: {option1}, Option2: {option2}, Option3: {option3}, Extra {extra}");
        }

        void CalculateSum()
        {
            double result = 0;
            while (true)
            {
                Console.WriteLine("Pls enter a number: ");
                String temp = Console.ReadLine();
                if(temp == "")
                {
                    Console.WriteLine("Enter pressed, Program Exit");
                    break;

                }
                else
                {
                    //int tempInt = Convert.ToInt32(temp);
                    //need to confirm whether it is number or not 
                    bool isNumeric = double.TryParse(temp, out double tempNumber);
                    if (isNumeric)
                    {
                        result += tempNumber;
                    }
                }
                
            }
            Console.WriteLine($"Result is: {result}");
        }

    }
}
