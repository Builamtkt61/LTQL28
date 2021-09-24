using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTQL28.Models
{
    public class Student
    {
        [Key]
        public string StudentID { get; set; }
        [Required(ErrorMessage = "Student name is required")]
        [MinLength(3)]

        public string StudentName { get; set; }
        [Required]
        public string Address { get; set; }
    }
}