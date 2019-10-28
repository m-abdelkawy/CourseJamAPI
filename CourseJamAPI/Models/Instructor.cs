using System.Collections.Generic;

namespace CourseJamAPI.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public int CenterId { get; set; }
        public Center Center { get; set; }
        public string Experience { get; set; }
        public List<Group> Groups { get; set; }
    }
}