using System;

namespace Akimov_Onuchin
{
    class Program
    {
        static void EnterTwoNumbers(ref double a, ref double b)
        {
            Console.WriteLine("Enter two int numbers:");

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
        }

        static double Addition(double a, double b)
        {
            return a+ b;
        }

        static double Subtraction(double a, double b)
        {
            return 0;
        }

        static double Divide(double a, double b)
        {
            return 0;
        }

        static double numToPow(double a, double b)
        {
            return 0;
        }

        static int Main()
        {
            int choice = 0;

            double a = 0, b = 0;

            do
            {
                Console.WriteLine("What do you want to do? (Enter number)");
                Console.WriteLine("1 - Enter two numbers");
                Console.WriteLine("2 - Add two numbers (default 0, 0)");
                Console.WriteLine("3 - Subtract two numbers (defaulr 0, 0)");
                Console.WriteLine("4 - Divide two numbers (default returns 0)");
                Console.WriteLine("5 - Raise a number number to the power (default returns 0)");
                Console.WriteLine("6 - Exit\n");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        EnterTwoNumbers(ref a, ref b);
                        break;
                    case 2:
                        Console.WriteLine($"a + b = {Addition(a, b)}");
                        break;
                    case 3:
                        Console.WriteLine($"a - b = {Subtraction(a, b)}");
                        break;
                    case 4:
                        Console.WriteLine($"a / b = {Divide(a, b)}");
                        break;
                    case 5:
                        Console.WriteLine($"a ^ b = {numToPow(a, b)}");
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Not an option!");
                        break;
                }
            } while (choice != 6);

            return 0;
        }
    }
}
