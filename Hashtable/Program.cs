using System;
using System.Collections;

namespace Hashtables
{
    internal class Program
    {
        // Key - Value
        // Auto - Car
        static void Main(string[] args)
        {
            // Create a Hashtable to store student information.
            Hashtable studentsTable = new Hashtable();

            // Create four Student objects.
            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);

            // Add the student objects to the Hashtable, using the student's ID as the key.
            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            // Retrieve an individual student object by knowing their ID.
            Student storedStudent1 = (Student)studentsTable[stud1.Id];

            // Iterate through all the values (Student objects) in the Hashtable.
            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("Student ID:{0}", value.Id);
                Console.WriteLine("Student Name:{0}", value.Name);
                Console.WriteLine("Student GPA:{0}", value.GPA);
            }
        }

        // Define a Student class to represent student information.
        class Student
        {
            // Properties for student ID, name, and GPA.
            public int Id { get; set; }
            public string Name { get; set; }
            public float GPA { get; set; }

            // Constructor to initialize student properties.
            public Student(int id, string name, float GPA)
            {
                this.Id = id;
                this.Name = name;
                this.GPA = GPA;
            }
        }
    }
}
