using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVSchool.Entities;
using MVSchool.Services;

namespace MVSchool.Web.Models
{
    public class StatisticsViewModel
    {
        public int NoOfCourses { get; set; }
        public int NoOfTrainers { get; set; }
        public int NoOfAssignments { get; set; }
        public int NoOfStudents { get; set; }

        public int NoStudPerCourse { get; set; }
        public int NoTrainPerCourse { get; set; }
        public int NoAssignPerCourse { get; set; }

        public Student StudentsPerCourse { get; set; }
        public Trainer TrainersPerCourse { get; set; }
        public Course Course { get; set; }


        public IEnumerable<Trainer> Trainers { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Assignment> Assignments { get; set; }


        public IEnumerable<double> AvgGradePerCourse { get; set; }
        public double AvgGradePerAssignment { get; set; }
        public double AvgGradePerAssignmentPerCourse { get; set; }

        
        
    }
}