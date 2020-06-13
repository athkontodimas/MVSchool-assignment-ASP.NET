using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MVSchool.Entities;

namespace MVSchool.Database
{
    public class MyDatabase :DbContext
    {
        public MyDatabase() :base("ConnectionDatabase")
        {

        }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Student> Students { get; set; }
       // public DbSet<StudentCourse> StudentCourses { get; set; }

        public DbSet<StudentAssignment> StudentAssignments { get; set; }

        public System.Data.Entity.DbSet<MVSchool.Entities.StudentCourse> StudentCourses { get; set; }
    }
}
