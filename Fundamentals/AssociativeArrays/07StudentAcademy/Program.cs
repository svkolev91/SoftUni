using System;
using System.Collections.Generic;
using System.Linq;

namespace _07StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPairs = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentsList = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfPairs; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsList.ContainsKey(studentName))
                {
                    studentsList[studentName] = new List<double>();
                    studentsList[studentName].Add(grade);
                }
                else
                {
                    studentsList[studentName].Add(grade);
                }
            }
            Dictionary<string, double> averageGradesList= new Dictionary<string, double>(); 

            foreach (var kvp in studentsList)
            {
                double newAverageGrade = kvp.Value.Average();
                if (newAverageGrade < 4.50)
                {
                    continue;
                }
                averageGradesList[kvp.Key] = newAverageGrade; 
            }

            foreach (var item in averageGradesList)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
