using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseJamAPI.Models
{
    public class Center:User
    {
        public string WebsiteUrl { get; set; }
        public List<Course> Courses { get; set; }
        public List<Instructor> Instructors { get; set; }
    }
}
