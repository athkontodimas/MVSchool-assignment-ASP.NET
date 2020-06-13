using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVSchool.Entities
{
    public class StudentAssignment
    {
       // public int Combo { get; set; }
        
        [Key, Column(Order = 1)]
       //[ForeignKey("Assignment")]
        public int AssignmentId { get; set; }
        [Key, Column(Order = 2)]
        public int StudentId { get; set; }
        [Key, Column(Order = 3)]
        public int CourseId { get; set; }

        [Required][Range(0,100)]
        public double Grade { get; set; }
        
        //Navigation properties
        public virtual Student Student { get; set; }
        public virtual Assignment Assignment { get; set; }
        public virtual Course Course { get; set; }


        // public virtual ICollection<Course> Courses { get; set; }


        // public static int Num { get; set; } = 0;

       // constructors
        // public StudentAssignment()
        //{


        //}


        //public StudentAssignment(Student student, Assignment assignment)
        //{

        //    Student = student;
        //    Assignment = assignment;
        //    Course = assignment.Course;
        //}


    }
}
