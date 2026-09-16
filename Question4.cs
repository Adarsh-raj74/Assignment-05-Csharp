using System;

namespace Assignment5
{
    internal class Question4
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter First Number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Second Number: ");
                int b = Convert.ToInt32(Console.ReadLine());
                int result = a / b;

            }
            catch (FormatException)
            {
                Console.WriteLine("Error: please enter numeric value only.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: cannot divided by zero.");
            }
            catch (Exception)
            {
                Console.WriteLine("Error: some unexpected error occurred");
            }

        }
    }
}
