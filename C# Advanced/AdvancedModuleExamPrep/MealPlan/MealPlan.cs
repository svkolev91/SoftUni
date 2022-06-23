using System;
using System.Collections.Generic;
using System.Linq;

class MealPlan
{

    static void Main()
    {
        const int Salad = 350;
        const int Soup = 490;
        const int Pasta = 680;
        const int Steak = 790;

        string[] meals = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries); 
        Queue<string> mealsQueue = new Queue<string>(meals);

        int[] calories = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        Stack<int> intakeCalories = new Stack<int>(calories);
        int mealCounter = 0;

        while (mealsQueue.Count > 0 && intakeCalories.Count > 0)
        {
            string checkMeal = mealsQueue.Dequeue();
            int currMeal = 0;
            if (checkMeal == "salad")
            {
                currMeal = Salad;
            }
            else if (checkMeal == "soup")
            {
                currMeal = Soup;
            }
            else if (checkMeal == "pasta")
            {
                currMeal = Pasta;
            }
            else if (checkMeal == "steak")
            {
                currMeal = Steak;
            }

            int availableCalories = intakeCalories.Pop();

            
            
            if (availableCalories >= currMeal)
            {
                availableCalories -= currMeal;
                mealCounter++;
                if (availableCalories > 0)
                {
                    intakeCalories.Push(availableCalories);
                }
            }
            else if (availableCalories < currMeal)
            {
                if (intakeCalories.Count == 0)
                {
                    intakeCalories.Clear();
                    mealCounter++;
                    break;
                }
                
                availableCalories += intakeCalories.Pop();
                availableCalories -= currMeal;
                mealCounter++;
                if (availableCalories > 0)
                {
                    intakeCalories.Push(availableCalories);
                }
            }

        }

        if (mealsQueue.Count == 0)
        {
            Console.WriteLine($"John had {mealCounter} meals.");
            Console.WriteLine($"For the next few days, he can eat {string.Join(", ",intakeCalories)} calories.");
        }
        else if (intakeCalories.Count == 0)
        {
            Console.WriteLine($"John ate enough, he had {mealCounter} meals.");
            Console.WriteLine($"Meals left: {string.Join(", ", mealsQueue)}.");
        }
    }
}
