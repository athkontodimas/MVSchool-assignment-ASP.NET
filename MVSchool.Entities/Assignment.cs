using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace MVSchool.Entities
{
    public class Assignment
    {
       //[ForeignKey("StudentAssignment")]
        public int AssignmentId { get; set; }
       
        [Required,MaxLength(60,ErrorMessage ="Reached max title length")]
        public string Title { get; set; }
       
        [Required]
        public DateTime SubmissionDate { get; set; }
      
         [MaxLength(200, ErrorMessage ="Enter a shorter description")]
        public string Description { get; set; }
       // public int? CourseId { get; set; }


        // Navigation property
        //public virtual Course Course { get; set; }
        public virtual ICollection<StudentAssignment> StudentAssignments { get; set; }

    }
}
