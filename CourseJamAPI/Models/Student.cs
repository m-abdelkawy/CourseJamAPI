using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseJamAPI.Models
{
    public class Student:User
    {
        public string Faculty { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime GraduationYear { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
    }
}
