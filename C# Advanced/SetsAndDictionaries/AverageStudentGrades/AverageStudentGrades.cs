using System;
using System.Collections.Generic;
using System.Linq;

class AverageStudentGrades
{

    //Create a program, which reads a name of a student and his/her grades and adds them to the student record,
    //then prints the students' names with their grades and their average grade.


    static void Main()
    {
        int numOfInputs = int.Parse(Console.ReadLine());

        Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

        for (int i = 0; i < numOfInputs; i++)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string studentName = input[0];
            decimal studentGrade = decimal.Parse(input[1]);

            AddGrade(students, studentName, studentGrade);
        }

        foreach (var student in students)
        {
            string studentName = student.Key;
            var grades = student.Value;

            Console.WriteLine($"{studentName} -> {string.Join(" ", student.Value)} (avg: {grades.Average():f2})");
        }
    }

    static void AddGrade(Dictionary<string, List<decimal>> students, string studentName, decimal studentGrade)
    {
        if (!students.ContainsKey(studentName))
        {
            students[studentName] = new List<decimal>();
            students[studentName].Add(studentGrade);
        }
        else
        {
            students[studentName].Add(studentGrade);
        }
    }
}
