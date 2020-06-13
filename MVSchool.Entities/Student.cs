using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVSchool.Entities
{
    public class Student
    {

        //[ForeignKey("StudentAssignment")]
        public int StudentId { get; set; }
        [Required,MaxLength(20,ErrorMessage ="First name should not be longer than 20 characters")]
        public string FirstName { get; set; }
        //[Required, MaxLength(25, ErrorMessage = "Last name should not be longer than 25 characters")]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }

        public string PhotoUrl { get; set; }

       public virtual ICollection<StudentAssignment> StudentAssignments { get; set; }
       public virtual ICollection<Course> Courses { get; set; }
        //[ForeignKey("StudentCourse")]
        //public virtual ICollection<StudentCourse> StudentCourse { get; set; }
        
    }
}
