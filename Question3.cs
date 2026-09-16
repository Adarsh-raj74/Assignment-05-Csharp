using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Question3
    {
        static void Main()
        {
            int[] number = { 10, 20, 30, 40, 50 };
            try
            {
                Console.WriteLine("Enter index (0 - 4)");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine("Value at index " + index + " is " + number[index]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: index out of range: please enter an index between 0 to 4");
            }
        }

    }
}
