using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTQL28.Models
{
    public class Account
    {
        [Key]
        public int MyProperty { get; set; }
    }
}