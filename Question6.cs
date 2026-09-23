using System;

class Program6
{
    static void Main6()
    {
        int[] marks = new int[5];

        for (int i = 0; i < 5; i++)
        {
            try
            {
                Console.Write("Enter marks for Subject " + (i + 1) + ": ");

                marks[i] = Convert.ToInt32(Console.ReadLine());

                if (marks[i] < 0 || marks[i] > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine("Marks accepted.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter numeric marks.");
                i--;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid marks! Marks must be between 0 and 100.");
                i--;
            }
            finally
            {
                Console.WriteLine("Input process completed.\n");
            }
        }

        Console.WriteLine("Student Marks:");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Subject " + (i + 1) + ": " + marks[i]);
        }
    }
}