using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseJamAPI.Models
{
    public class UserInterest
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int interestId { get; set; }
        public Interest Interest { get; set; }
    }
}
