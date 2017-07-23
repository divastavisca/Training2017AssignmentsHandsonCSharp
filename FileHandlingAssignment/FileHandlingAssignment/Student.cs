using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportLibrary;
using Newtonsoft.Json;

namespace FileHandlingAssignment
{
    public class Student 
    {
        /// <summary>
        /// First name of person
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of person
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Mobile number of student
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// Email Id of student
        /// </summary>
        public string EmailId { get; set; }

        /// <summary>
        /// Mailing Address of student
        /// </summary>
        public string MailingAddress { get; set; }

        /// <summary>
        /// Date of Birth of student
        /// </summary>
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Course the student is pursuing
        /// </summary>
        public string Course { get; set; }

        /// <summary>
        /// Student's mentor name
        /// </summary>
        public string MentorName { get; set; }

        /// <summary>
        /// Emergency contact number of the student
        /// </summary>
        public string EmergencyNumber { get; set; }

        public override string ToString()
        {
            return (JsonConvert.SerializeObject(this));
        }
    }
}
