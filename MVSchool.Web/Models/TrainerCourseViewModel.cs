using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVSchool.Database;
using MVSchool.Entities;
using MVSchool.Services;

namespace MVSchool.Web.Models
{
    public class TrainerCourseViewModel
    {
        public IEnumerable<Trainer> Trainers { get; set; }
        public IEnumerable<Course> Courses { get; set; }


      
    }
}