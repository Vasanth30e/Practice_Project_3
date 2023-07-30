using System.Collections.Generic;

namespace PracticeProject3
{
    public class Searching
    {
        // Binary Search to search for a student by name
        public static Student BinarySearch(List<Student> students, string searchName)
        {
            int left = 0;
            int right = students.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int compareResult = string.Compare(students[mid].Name, searchName);

                if (compareResult == 0)
                {
                    return students[mid]; // Student found
                }
                else if (compareResult < 0)
                {
                    left = mid + 1; // Search in the right half
                }
                else
                {
                    right = mid - 1; // Search in the left half
                }
            }

            return null; // Student not found
        }
    }
}
