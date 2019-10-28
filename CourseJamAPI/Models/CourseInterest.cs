using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseJamAPI.Models
{
    public class CourseInterest
    {
        public int InterestId { get; set; }
        public Interest Interest { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
