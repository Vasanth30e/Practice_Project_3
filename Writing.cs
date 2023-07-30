using System.Collections.Generic;
using System.IO;

namespace PracticeProject3
{
    public class Writing
    {
        // Function to write the student data back to the file, overwriting the original data
        public static void WriteStudentDataToFile(string filePath, List<Student> students)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Rainbow School");
                writer.WriteLine("--------------");
                writer.WriteLine("Student Details");
                writer.WriteLine("-------------------------------------");
                writer.WriteLine("Student Name  Student Id  Student Age");
                writer.WriteLine("------------  ----------  -----------");

                foreach (Student student in students)
                {
                    writer.WriteLine($"{student.Name,-13} {student.Id,-11} {student.Age,-11}");
                }

                writer.WriteLine("-------------------------------------");
            }
        }
    }
}
