using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary
{
    /// <summary>
    /// Defines a specific user by its gender and mailing address
    /// </summary>
    public class User : Person
    {
        public int GenderId { get; set; }
        public Address mailingAddress; 

        public User() //Creates a new user instance
        {
            mailingAddress = new Address();
        }
    }
}
