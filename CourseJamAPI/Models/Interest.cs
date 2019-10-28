using System.Collections.Generic;

namespace CourseJamAPI.Models
{
    public class Interest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}