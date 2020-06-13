using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVSchool.Entities
{
    public class Course
    {
        //[ForeignKey("StudentCourse")]
        public int CourseId { get; set; }
        [Required, MaxLength(120, ErrorMessage ="Title should not be longer than 120 characters")]
        public string Title { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        //public int TrainerId { get; set; }  //foreign key to trainer 1 trainer -to-many courses
       

        
        public virtual ICollection<StudentAssignment> StudentAssignments { get; set; }
        //Navigation property
        [Display(Name = "Teaching:")]
        public virtual Trainer Trainer { get; set; }
        [Display(Name="Enrolled Students")]
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
      
        //public virtual ICollection<StudentCourse> StudentCourse { get; set; }

    }
}
