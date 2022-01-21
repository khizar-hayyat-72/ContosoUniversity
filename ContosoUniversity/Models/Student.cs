using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Required LastName")]
        [Display(Name = "First Name", Prompt = "Enter First Name", Description = "Student First Name")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Required FirstMidName")]

        public string? FirstMidName { get; set; }

        [Required(ErrorMessage = "Required EneollmentDate")]
        public DateTime EnrollmentDate { get; set; }


        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}