using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.IO;
using SupportLibrary;

namespace FileHandlingAssignment
{
    public class StudentDataManager
    {

        InputFromConsole reader = new InputFromConsole(); //Custom console
        /// <summary>
        /// Physical path of data resource directory
        /// </summary>
        string path = "D:/StudentInfoConsole/";

        /// <summary>
        /// Add a new student record to a physical directory
        /// </summary>
        public void AddStudent()
        {
            if (StoreRecord(GetStudent()))
            {
                Console.WriteLine("Your details have been saved\nPress Enter");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

        /// <summary>
        /// Stores a student record by creating a new file or logs an error when not done
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public bool StoreRecord(Student student)
        {
            string fileName = path + student.FirstName + student.MobileNumber + ".txt";
            if (!File.Exists(fileName))
            {
                using (File.Create(fileName))
                {

                }
                File.AppendAllText(fileName, student.ToString());
                if (!File.Exists(path + "info.txt"))
                {
                    using (File.Create(path + "info.txt"))
                    {

                    }
                }
                StudentRecord record = new StudentRecord();
                record.filename = fileName;
                record.logTime = DateTime.UtcNow;
                File.AppendAllText(path + "info.txt", record.ToString());
                Logger.AddLog("New student record added " + record);
                return true;
            }
            else
            {
                Logger.AddLog("Conflict in student data entry or file issues " + DateTime.UtcNow.ToString() + " " + student);
                return false;
            }
        }

        /// <summary>
        /// Get Json for logging errors
        /// </summary>
        /// <param name="student"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public string GetJson(Student student, string fileName)
        {
            return (DateTime.UtcNow.ToString() + " " + student.FirstName + " " + student.LastName + " " + student.MobileNumber + " " + student.EmailId + " " + fileName);
        }

        /// <summary>
        /// Get valid student details 
        /// </summary>
        /// <param name="statement"></param>
        /// <param name="regEx"></param>
        /// <returns></returns>
        public string GetValidInput(string statement, string regEx)
        {
            string value = "";
            while (true)
            {
                value = reader.Read(statement);
                if (Regex.IsMatch(value, regEx))  //regular expression check
                    break;
                else Console.WriteLine("Invalid Input");
            }
            return value;
        }

        /// <summary>
        /// Takes input from console
        /// </summary>
        /// <returns></returns>
        public Student GetStudent()
        {
            Student newStudent = new Student();
            //Get valid input from console using regular expression validation
            #region
            try
            {
                newStudent.FirstName = GetValidInput("Enter first name", "^[a-zA-Z]");
                newStudent.LastName = GetValidInput("Enter last name", "[a-zA-Z]$");
                newStudent.MobileNumber = GetValidInput("Enter mobile number", "^[0-9]{10}$");
                newStudent.EmailId = GetValidInput("Enter email id", @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-z]{2,3}$");
                newStudent.MailingAddress = reader.Read("Enter address");
                newStudent.DateOfBirth = GetValidInput("Enter DOB", "^(?:(?:31(\\/|-|\\.)(?:0?[13578]|1[02]))\\1|(?:(?:29|30)(\\/|-|\\.)(?:0?[1,3-9]|1[0-2])\\2))(?:(?:1[6-9]|[2-9]\\d)?\\d{2})$|^(?:29(\\/|-|\\.)0?2\\3(?:(?:(?:1[6-9]|[2-9]\\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\\d|2[0-8])(\\/|-|\\.)(?:(?:0?[1-9])|(?:1[0-2]))\\4(?:(?:1[6-9]|[2-9]\\d)?\\d{2})$");
                newStudent.Course = reader.Read("Enter the course you are pursuing");
                newStudent.MentorName = GetValidInput("Enter mentors name", "^[a-zA-Z]+ [a-zA-Z]+$");
                newStudent.EmergencyNumber = GetValidInput("Enter emergency number", "^[0-9]{10}$");
            }
            catch (Exception exception)
            {
                Logger.AddLog(DateTime.UtcNow.ToString() + " " + exception.ToString());
            }
            #endregion
            return newStudent;      //return valid student details
        }

        /// <summary>
        /// View a specific student info
        /// </summary>
        public void ViewStudent()
        {
            string name = GetValidInput("Enter first name", "^[a-zA-Z]");
            string mobileNumber = GetValidInput("Enter your mobile number", "^[0-9]{10}$");
            string fileName = path + name + mobileNumber + ".txt";
            if (File.Exists(fileName))
            {
                Student student = JsonConvert.DeserializeObject<Student>(File.ReadAllText(fileName));
                PrintStudent(student);
                Console.ReadKey();
            }
            else Console.WriteLine("No such student exists");
        }

        public void Students()
        {
            if (File.Exists(path + "info.txt"))
            {
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    if (file != path + "log.txt" && file != path + "info.txt" && File.Exists(file))
                    {
                        PrintStudent(JsonConvert.DeserializeObject<Student>(File.ReadAllText(file)));
                    }
                }
            }
            else Console.WriteLine("No data found!");
        }

        /// <summary>
        /// Print student details
        /// </summary>
        /// <param name="student"></param>
        public void PrintStudent(Student student)
        {
            Console.WriteLine("First Name: " + student.FirstName);
            Console.WriteLine("Last Name: " + student.LastName);
            Console.WriteLine("Mobile number: " + student.EmailId);
            Console.WriteLine("Address: " + student.MailingAddress);
            Console.WriteLine("Date of birth: " + student.DateOfBirth);
            Console.WriteLine("Course: " + student.Course);
            Console.WriteLine("Mentor name: " + student.MentorName);
            Console.WriteLine("Emergency number: " + student.EmergencyNumber);
            Console.WriteLine("--------------------------------------------");
        }

        public void UpdateStudent()
        {
            string name = GetValidInput("Enter first name", "^[a-zA-Z]");
            string mobileNumber = GetValidInput("Enter your mobile number", "^[0-9]{10}$");
            string fileName = path + name + mobileNumber + ".txt";
            if (File.Exists(fileName))
            {
                Student student = JsonConvert.DeserializeObject<Student>(File.ReadAllText(fileName));
                Console.WriteLine("Enter new details");
                try
                {
                    student.FirstName = GetValidInput("Enter first name", "^[a-zA-Z]");
                    student.LastName = GetValidInput("Enter last name", "[a-zA-Z]$");
                    student.MobileNumber = GetValidInput("Enter mobile number", "^[0-9]{10}$");
                    student.EmailId = GetValidInput("Enter email id", @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-z]{2,3}$");
                    student.MailingAddress = reader.Read("Enter address");
                    student.DateOfBirth = GetValidInput("Enter DOB", "^(?:(?:31(\\/|-|\\.)(?:0?[13578]|1[02]))\\1|(?:(?:29|30)(\\/|-|\\.)(?:0?[1,3-9]|1[0-2])\\2))(?:(?:1[6-9]|[2-9]\\d)?\\d{2})$|^(?:29(\\/|-|\\.)0?2\\3(?:(?:(?:1[6-9]|[2-9]\\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\\d|2[0-8])(\\/|-|\\.)(?:(?:0?[1-9])|(?:1[0-2]))\\4(?:(?:1[6-9]|[2-9]\\d)?\\d{2})$");
                    student.Course = reader.Read("Enter the course you are pursuing");
                    student.MentorName = GetValidInput("Enter mentors name", "^[a-zA-Z]+ [a-zA-Z]+$");
                    student.EmergencyNumber = GetValidInput("Enter emergency number", "^[0-9]{10}$");
                    File.WriteAllText(fileName, student.ToString());
                    Logger.AddLog("New update request succeeded " + DateTime.UtcNow.ToString() + "for name: " + name + "for mobile number: " + mobileNumber);
                }
                catch (Exception exception)
                {
                    Logger.AddLog(DateTime.UtcNow.ToString() + " " + exception.ToString());
                }
            }
            else Console.WriteLine("No such file exists");
            Logger.AddLog("New update request failed " + DateTime.UtcNow.ToString() + "for name: " + name +"for mobile number: "+mobileNumber );

        }
    }
}
