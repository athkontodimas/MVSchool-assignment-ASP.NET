using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVSchool.Entities
{
    public class StudentCourse
    {
        [Key, Column(Order = 1)]
        public int StudentId { get; set; }
        [Key, Column(Order = 2)]
        public int CourseId { get; set; }
       
        public int TuitionFees { get; set; } //εκτος αν μπει στα courses ανά μάθημα 
        public int Onoma { get; set; }
        private static int Num { get; set; } = 0;
    //constructors
    //public StudentCourse(){}

    //     static StudentCourse()
    //    {
    //        Num += 1;
    //    }
    //    public StudentCourse(Student student, Course course)
    //    {
           
    //        Onoma =/*$"{student.StudentId} + {course.CourseId} + */Num;
    //        StudentId = student.StudentId;
    //        CourseId = course.CourseId;
    //    }

        //Navigation properties

        public virtual Student Student { get; set; }
       
        public virtual Course Course { get; set; }
        //public virtual ICollection<Assignment> Assignments { get; set; }



    }
}
