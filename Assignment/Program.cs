using System;
using System.Collections;
using Assignment;

namespace Students_Management
{
    class Program
    {
        public static ArrayList students = new ArrayList();
        static void ShowMenu()
        {
            Console.WriteLine("\n1. Insert new Students\n2. View list of Students\n3. Search Students\n4. Exit\nPlease enter your choice: ");
            Choice(Console.ReadLine());
        }

        static void Seeder()
        {
            students.Add(new Student("Phan Van Hoang Hung", "26/11/1999", "Express", "T1708E", "yes", 0972545780));
        }

        static void Continue()
        {
            Console.WriteLine("\nDo you want continue? (y/n)");
            switch (Console.ReadLine())
            {
                case "y":
                    ShowMenu();
                    break;
                case "n":
                    Environment.Exit(0);
                    break;
                case "":
                    Environment.Exit(0);
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }

        static void Choice(string choice)
        {
            switch (choice.ToString())
            {
                case "1":
                    Student student = new Student();
                    Console.WriteLine("Full Name: ");
                    student.FullName = Console.ReadLine();
                    Console.WriteLine("Date of Birth: ");
                    student.DateofBirth = Console.ReadLine();
                    Console.WriteLine("Native: ");
                    student.Native = Console.ReadLine();
                    Console.WriteLine("Class: ");
                    student.Class = Console.ReadLine();
                    Console.WriteLine("PhoneNo: ");
                    student.PhoneNo = Console.ReadLine();
                    Console.WriteLine("Mobile: ");
                    student.Mobile = Int32.Parse(Console.ReadLine());
                    students.Add(student);
                    Console.WriteLine("Add Student succes!");
                    Continue();
                    break;
                case "2":
                    if (students.Count > 0)
                    {
                        foreach (Student st in students)
                        {
                            st.Display();
                        }
                        Console.WriteLine("\n");
                        Continue();
                    }
                    else
                    {
                        Console.WriteLine("There are no students on the list");
                        Continue();
                    }
                    break;
                case "3":
                    if (students.Count > 0)
                    {
                        Console.WriteLine("Search student by name, please enter the name you want to search: ");
                        var name = Console.ReadLine();
                        var count = 0;
                        foreach (Student st in students)
                        {
                            if (st.FullName.Contains(name))
                            {
                                st.Display();
                                count++;
                            };
                        }
                        if (count == 0)
                        {
                            Console.WriteLine($"No students have the same name as the keyword {name}!");
                        }
                        Console.WriteLine("\n");
                        Continue();
                    }
                    else
                    {
                        Console.WriteLine("No data");
                        Continue();
                    }
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                case "":
                    Continue();
                    break;
                default:
                    Console.WriteLine("Please select only numbers from 1 to 4.");
                    Continue();
                    break;
            };
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Students Management by Phan Van Hoang Hung:");
            Seeder();
            ShowMenu();
        }
    }
}
