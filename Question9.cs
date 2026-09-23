using System;
using System.IO;

class StudentFile
{
    static void Main()
    {
        string filePath = "student.txt";

        // Create and write data into the file
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Student Name: Adarsh");
            writer.WriteLine("Roll Number: 101");
            writer.WriteLine("Course: MCA");
            writer.WriteLine("College: GLA University");
            writer.WriteLine("CGPA: 8.2");
        }

        Console.WriteLine("Student details written successfully.\n");

        // Read data from the file
        using (StreamReader reader = new StreamReader(filePath))
        {
            string data = reader.ReadToEnd();

            Console.WriteLine("Student Details:");
            Console.WriteLine("----------------");
            Console.WriteLine(data);
        }
    }
}