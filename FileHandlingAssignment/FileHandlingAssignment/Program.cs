using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace FileHandlingAssignment
{
    public class Program
    {

        /// <summary>
        /// Manages all student management tasks
        /// </summary>
        static StudentDataManager manager = new StudentDataManager();

        /// <summary>
        /// Main executing thread
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            CreateDirectory();
            while (true)
            {
                Menu(); //Menu to print application choices
                int choice;
                if (!Int32.TryParse(Console.ReadLine(), out choice))
                    continue;
                switch(choice)
                {
                    case 1:
                        manager.AddStudent();   //Add a student
                        break;
                    case 2: 
                        manager.ViewStudent();  //View a student
                        break;
                    case 3:
                        manager.Students();     //View all students
                        break;
                    case 4:
                        manager.UpdateStudent();  //Update existing student details
                        break;
                    case 5:
                        Environment.Exit(1);       //exit
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }

        /// <summary>
        /// Print main menu
        /// </summary>
        static void Menu()
        {
            Console.WriteLine("Enter your choice\n");
            Console.WriteLine("1)Add a student");
            Console.WriteLine("2)Display a student");
            Console.WriteLine("3)Display all students");
            Console.WriteLine("4)Update a student record");
            Console.WriteLine("5)Exit");
        }

        /// <summary>
        /// Creates the data directory if not exists
        /// </summary>
        static void CreateDirectory()
        {
            if (!Directory.Exists("D:/StudentInfoConsole"))
                Directory.CreateDirectory("D:/StudentInfoConsole");
        }
    }
}
