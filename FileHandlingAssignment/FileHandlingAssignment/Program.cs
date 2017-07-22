using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace FileHandlingAssignment
{
    class Program
    {
        static StudentDataManager manager = new StudentDataManager();
        static void Main(string[] args)
        {
            while(true)
            {
                Menu();
                int choice;
                if (!Int32.TryParse(Console.ReadLine(), out choice))
                    continue;
                switch(choice)
                {
                    case 1:
                        manager.AddStudent();
                        break;
                    case 2:
                        manager.ViewStudent();
                        break;
                    case 3:
                        manager.Students();
                        break;
                    case 4:
                        manager.UpdateStudent();
                        break;
                    case 5:
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }

        static void Menu()
        {
            Console.WriteLine("Enter your choice\n");
            Console.WriteLine("1)Add a student");
            Console.WriteLine("2)Display a student");
            Console.WriteLine("3)Display all students");
            Console.WriteLine("4)Update a student record");
            Console.WriteLine("5)Exit");
        }

       
    }
}
