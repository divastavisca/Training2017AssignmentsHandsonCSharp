using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FileHandlingAssignment
{
    public class StudentRecord
    {
        public DateTime logTime { get; set; }
        public string filename {get; set;}

        public override string ToString()
        {
            return (JsonConvert.SerializeObject(this));
        }
    }
}
