using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<string> tasks = new List<string>();

    static void Main()
    {
        Console.WriteLine("Welcome to the To-Do List App");

        while (true)
{
    Console.WriteLine("\nChoose an option:");
    Console.WriteLine("1. View Tasks");
    Console.WriteLine("2. Add Task");
    Console.WriteLine("3. Delete Task");
    Console.WriteLine("4. Exit");

    Console.Write("Enter your choice (1-4): ");
    string input = Console.ReadLine() ?? "";

    if (input == "1")
    {
        ViewTasks();
    }
    else if (input == "2")
    {
        AddTask();
    }
    else if (input == "3")
    {
        DeleteTask();
    }
    else if (input == "4")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid choice. Please try again.");
    }
}

    }
static void ViewTasks()
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("No tasks found.");
        return;
    }

    Console.WriteLine("\nYour To-Do List:");
    for (int i = 0; i < tasks.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {tasks[i]}");
    }
}

static void AddTask()
{
    Console.Write("Enter the task to add: ");
    string newTask = Console.ReadLine() ?? "";

    if (string.IsNullOrWhiteSpace(newTask))
    {
        Console.WriteLine("Task cannot be empty.");
        return;
    }

    tasks.Add(newTask);
    Console.WriteLine($"Task \"{newTask}\" added successfully.");
}

static void DeleteTask()
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("No tasks to delete.");
        return;
    }

    ViewTasks();  // Show the current tasks

    Console.Write("Enter the task number to delete: ");
    string input = Console.ReadLine() ?? "";

    if (int.TryParse(input, out int index))
    {
        if (index >= 1 && index <= tasks.Count)
        {
            string removedTask = tasks[index - 1];
            tasks.RemoveAt(index - 1);
            Console.WriteLine($"Task \"{removedTask}\" deleted successfully.");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid number.");
    }
}

}