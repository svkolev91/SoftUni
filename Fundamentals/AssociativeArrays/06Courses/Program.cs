using System;
using System.Collections.Generic;
using System.Linq;

namespace _06Courses
{
    //class Students
    //{
    //    public Students(List<string> students)
    //    {
    //        this.studentsList = new List<string>();
    //    }
    //    public List<string> studentsList { get; set; }
    //}
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();  

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] detailsArr = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string currCourse = detailsArr[0];
                string currStudent = detailsArr[1];

                if (!courses.ContainsKey(currCourse))
                {
                    courses.Add(currCourse, new List<string>());
                    courses[currCourse].Add(currStudent);
                }
                else
                {
                    courses[currCourse].Add(currStudent);
                }

                input= Console.ReadLine();
            } 

            PrintResults(courses);

        }

        static void PrintResults(Dictionary<string, List<string>> courses)
        {
            foreach (var item in courses)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var student in item.Value)
                {
                    Console.WriteLine($"-- {string.Join("",student)}");
                }
            }
        }
    }
}
