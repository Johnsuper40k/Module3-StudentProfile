# Module3-StudentProfile
using System;

namespace StudentProfile
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    public class Student : Person
    {
        public string StudentID { get; set; }
        public string Major { get; set; }
        public string ClassStanding { get; set; } // NEW: Freshman, Sophomore, etc.

        public void DisplayStudentInfo()
        {
            DisplayInfo(); // from Person
            Console.WriteLine($"Student ID: {StudentID}, Major: {Major}, Class Standing: {ClassStanding}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Name = "Jon Doe",
                Age = 21,
                StudentID = "S12345",
                Major = "Computer Programming",
                ClassStanding = "First Year" // SET HERE
            };

            student.DisplayStudentInfo();
        }
    }
}
