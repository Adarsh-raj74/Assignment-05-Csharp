using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    internal class Question10
    {
        static void Main()
        {
            string filePath = "marks.txt";

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    int total = 0;
                    int count = 0;
                    int highest = int.MinValue;
                    int lowest = int.MaxValue;

                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        int marks = int.Parse(line);

                        total += marks;
                        count++;

                        if (marks > highest)
                            highest = marks;

                        if (marks < lowest)
                            lowest = marks;
                    }

                    if (count == 0)
                    {
                        Console.WriteLine("The file is empty.");
                    }
                    else
                    {
                        double average = (double)total / count;

                        Console.WriteLine("Total Marks = " + total);
                        Console.WriteLine("Average Marks = " + average);
                        Console.WriteLine("Highest Marks = " + highest);
                        Console.WriteLine("Lowest Marks = " + lowest);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: marks.txt file was not found.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: File contains invalid marks.");
            }
            catch (IOException)
            {
                Console.WriteLine("Error while reading the file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}
