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
        public int StudentID { get; set; }

        public string StudentName { get; set; }
    }
}