using System;
using System.Collections.Generic;
using System.IO;

namespace PracticeProject3
{
    public class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }

        // Function to read student data from the file and return a list of Student objects
        public static List<Student> ReadStudentDataFromFile(string filePath)
        {
            List<Student> students = new List<Student>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                // Skip the header lines
                string line = reader.ReadLine(); // Rainbow School
                while (!line.Contains("------------")) line = reader.ReadLine(); // Skip until the line with dashes
                while (!line.Contains("------------")) line = reader.ReadLine(); // Skip the line with dashes
                while (!line.Contains("Student Name  Student Id  Student Age")) line = reader.ReadLine(); // Skip the header line

                // Read the student data
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    if (line.Contains("-------------------------------------"))
                        break;

                    string[] data = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    try
                    {
                        Student student = new Student
                        {
                            Name = data[0],
                            Id = int.Parse(data[1]),
                            Age = int.Parse(data[2])
                        };

                        students.Add(student);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error!!!" + ex.Message);
                    }

                }
            }

            return students;
        }
    }   
}
