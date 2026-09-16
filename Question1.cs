using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Question1
    {
        static void Main1(string[] args)
        {

            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divided by zero");

            }
        }
    }
}
