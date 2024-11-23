using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Eternal Quest!");

        List<BaseGoal> goals = new List<BaseGoal>();

        int userInput = 0;
        int totalPoints = 0;

        while (userInput != 6)
        {
        Console.WriteLine($"Total Points: {totalPoints}");

        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
        userInput = int.Parse(Console.ReadLine());

        if (userInput == 1)
        {
            Console.WriteLine("Please select a goal type.");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which goal would you like to create: ");
            int userResponse = int.Parse(Console.ReadLine());

                if (userResponse == 1)
                {   
                    SimpleGoal simGoal = new SimpleGoal("", "", false, 0, 0);
                    simGoal.CreateGoal();
                    goals.Add(simGoal);
                }
                else if (userResponse == 2)
                {
                    EternalGoal eternGoal = new EternalGoal("", "", false, 0, 0);
                    eternGoal.CreateGoal();
                    goals.Add(eternGoal);
                }
                else if (userResponse == 3)
                {
                    ChecklistGoal checkGoal = new ChecklistGoal("", "", false, 0, 0, 0, 0, 0);
                    checkGoal.CreateGoal();
                    goals.Add(checkGoal);
                }
            
        }
        else if (userInput == 2)
        {
            Console.Clear();
            Console.WriteLine("Goals: ");
            foreach (var goal in goals)
            {
                goal.DisplayGoalStatus();
            }
        }
        else if (userInput == 3) // Save
        {
            Console.WriteLine("What is the file name to save to? ");
            string fileName = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var goal in goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
        }
        else if (userInput == 4) // Load
        {
            Console.WriteLine("What is the file to load? ");
            string fileName = Console.ReadLine();

            if (!File.Exists(fileName))
            {
                Console.WriteLine("This file does not exist.");
            }

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length > 1)
                    {                    
                    string goalType = parts[0].Trim();
                    string goalData = parts[1].Trim();

                    BaseGoal goal = null;

                    if (goalType == "SimpleGoal")
                    {
                        goal = SimpleGoal.CreateSimpleGoalFromString(goalData);
                    }
                    else if (goalType == "EternalGoal")
                    {
                        goal = EternalGoal.CreateEternalGoalFromString(goalData);
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        goal = ChecklistGoal.CreateChecklistGoalFromString(goalData);
                    }
                    if (goal != null)
                    {
                        goals.Add(goal);
                    }
                    }
                }
            }
            
        }
        else if (userInput == 5)
        {
            int i = 1;
            Console.WriteLine("The goals are: ");
            foreach (var goal in goals)
            {
                Console.WriteLine($"{i}. {goal._goalName}");
                i++;
            }
            Console.Write("Which goal was completed? ");
            int completedGoal = int.Parse(Console.ReadLine());

            if (completedGoal >= 1 && completedGoal <= goals.Count)
            {
                goals[completedGoal - 1].RecordEvent();
                totalPoints = 0;
                foreach (var goal in goals)
                {
                    totalPoints += goal.GetPoints();
                }
                Console.WriteLine($"You have earned {totalPoints} points!");
            }
        }
        }
    }
}