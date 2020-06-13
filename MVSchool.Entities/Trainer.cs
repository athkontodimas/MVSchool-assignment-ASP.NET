using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVSchool.Entities
{
    public class Trainer
    {
       // [ForeignKey("Course")]
        public int TrainerId { get; set; }
        [Required, MaxLength(20, ErrorMessage = "First name should not be longer than 20 characters"), Display(Name = "First name")]
        public string FirstName { get; set; }
        [Required, MaxLength(25, ErrorMessage = "Last name should not be longer than 25 characters"), Display(Name = "Last name")]
        public string LastName { get; set; }
        [Required, MaxLength(30,ErrorMessage ="Subject should not exceed 30 characters")]
        public string Subject { get; set; }
       
        [Display(Name="Teaching in:")]
        public virtual ICollection<Course> Courses { get; set; }
    }
}
