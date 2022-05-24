using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Students
{
    class Student
    {

        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;   
            this.Grade = grade;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

    }

    class ListOfStudents
    {
        public ListOfStudents()
        {
            this.listOfStudents = new List<Student>();
        }
        
        public List<Student> listOfStudents { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            ListOfStudents students = new ListOfStudents();


            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstName = input[0];    
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                students.listOfStudents.Add(new Student(firstName, lastName, grade));
            }

            List<Student> sortedStudents = students.listOfStudents.OrderByDescending(grade => grade.Grade)
                .ToList();

            foreach (Student student in sortedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
}
