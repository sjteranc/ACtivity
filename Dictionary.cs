using System;
using System.Collections.Generic;

namespace ACtivity
{
    public class DictironaryOperations
    {
        private Dictionary<string, int> students;
        public DictironaryOperations()
        {
            students = new Dictionary<string, int>();
        }
        public void AddStudents()
        {
            students.Add("Maria", 20);
            students.Add("John", 22);
            students.Add("Peter", 21);
            students.Add("Sara", 23);
            students.Add("David", 24);  
        }
        public void PrintStudents()
        {
            foreach (var students in students)
            {
                Console.WriteLine($"Name: {students.Key}, Age: {students.Value}");
            }
        }
    }

}