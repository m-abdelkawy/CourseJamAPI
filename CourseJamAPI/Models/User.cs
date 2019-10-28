using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseJamAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Location { get; set; }
        public string PhoneNumber { get; set; }
        public List<Interest> Interests { get; set; }
        public List<Notification> Notifications { get; set; }
    }
}
