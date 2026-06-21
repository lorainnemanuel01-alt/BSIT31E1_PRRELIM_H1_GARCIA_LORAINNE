using System;
using System.Collections.Generic;

class StudentManager
{
    private List<string> studentNames;
    private List<double> studentGrades;

    public StudentManager()
    {
        studentNames = new List<string>();
        studentGrades = new List<double>();
    }

    public void Run()
    {
        int choice;

        do
        {
            Console.Clear();
            Console.WriteLine("===== STUDENT MANAGEMENT SYSTEM =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Class Average");
            Console.WriteLine("4. Top Student");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    ViewStudents();
                    break;
                case 3:
                    ShowClassAverage();
                    break;
                case 4:
                    ShowTopStudent();
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            if (choice != 5)
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }

        } while (choice != 5);
    }

    public void AddStudent()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Console.Write("Enter grade: ");
        double grade = Convert.ToDouble(Console.ReadLine());

        studentNames.Add(name);
        studentGrades.Add(grade);

        Console.WriteLine("Student added successfully!");
    }

    public void ViewStudents()
    {
        if (studentNames.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        Console.WriteLine("\nStudent List");
        for (int i = 0; i < studentNames.Count; i++)
        {
            Console.WriteLine($"{studentNames[i]} - {studentGrades[i]}");
        }
    }

    public void ShowClassAverage()
    {
        if (studentGrades.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        double total = 0;
        foreach (double grade in studentGrades)
        {
            total += grade;
        }

        double average = total / studentGrades.Count;
        Console.WriteLine($"Class Average: {average:F2}");
    }

    public void ShowTopStudent()
    {
        if (studentGrades.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        double highest = studentGrades[0];
        int index = 0;

        for (int i = 1; i < studentGrades.Count; i++)
        {
            if (studentGrades[i] > highest)
            {
                highest = studentGrades[i];
                index = i;
            }
        }

        Console.WriteLine($"Top Student: {studentNames[index]}");
        Console.WriteLine($"Highest Grade: {highest}");
    }
}
