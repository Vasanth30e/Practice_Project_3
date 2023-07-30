using System;
using System.Collections.Generic;

namespace PracticeProject3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the data from the text file and store it in a list of Student objects
            List<Student> students = Student.ReadStudentDataFromFile("D:\\Training\\Assisted Projects\\Pratice Projects\\PracticeProject3\\PracticeProject3\\StudentData.txt");

            // Perform insertion sort on the list based on student names
            Sorting.InsertionSort(students);

            // Overwrite the original file with the sorted student data
            Writing.WriteStudentDataToFile("sorted_student_data.txt", students);

            // Display the sorted data
            Console.WriteLine("Sorted Student Data:");
            Sorting.DisplayStudentData(students);

            // Loop for searching students
            while (true)
            {
                Console.WriteLine("Enter the Student Name to Search (or 'n' to quit):");
                string searchName = Console.ReadLine();

                if (searchName.ToLower() == "n")
                {
                    break; // Exit the loop if the user enters 'n'
                }

                Student foundStudent = Searching.BinarySearch(students, searchName);

                if (foundStudent != null)
                {
                    Console.WriteLine($"Student found: {foundStudent.Name}, ID: {foundStudent.Id}, Age: {foundStudent.Age}");
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }

            Console.WriteLine("Program Ended");

            Console.ReadKey();

        }
    }
}
