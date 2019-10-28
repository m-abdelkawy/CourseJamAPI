using System;
using System.Collections.Generic;

namespace CourseJamAPI.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public int Chairs { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public List<StudentGroup> StudentGroups { get; set; }
    }
}