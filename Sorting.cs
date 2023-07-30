using System;
using System.Collections.Generic;

namespace PracticeProject3
{
    public class Sorting
    {
        // Insertion Sort to sort the list of students based on their names
        public static void InsertionSort(List<Student> students)
        {
            for (int i = 1; i < students.Count; i++)
            {
                Student key = students[i];
                int j = i - 1;

                while (j >= 0 && string.Compare(students[j].Name, key.Name) > 0)
                {
                    students[j + 1] = students[j];
                    j = j - 1;
                }

                students[j + 1] = key;
            }
        }

        // Function to display the student data
        public static void DisplayStudentData(List<Student> students)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Student Name  Student Id  Student Age");
            Console.WriteLine("------------  ----------  -----------");

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name,-13} {student.Id,-11} {student.Age,-11}");
            }

            Console.WriteLine("-------------------------------------");
        }
    }
}
