using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 

namespace CourseJamAPI.Models
{
    public class CourseJamContext : DbContext
    {
        public CourseJamContext(DbContextOptions<CourseJamContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<StudentGroup>(StGps =>
            {
                StGps.HasKey(StGp => new { StGp.GroupId, StGp.StudentId });
                StGps.HasOne(StGp => StGp.Group).WithMany(gr => gr.StudentGroups).
                HasForeignKey(StGp=>StGp.GroupId).OnDelete(DeleteBehavior.Restrict);

                StGps.HasOne(StGp => StGp.Student).WithMany(gr => gr.StudentGroups).
                HasForeignKey(StGp => StGp.StudentId).OnDelete(DeleteBehavior.Restrict);
            });  
        }
        public DbSet<Center> Centers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
