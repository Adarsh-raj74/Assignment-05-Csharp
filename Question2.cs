using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Question2
    {
      static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an integer:");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("You Entered: " + number );
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid integer.");
            }
        }
    }
}
