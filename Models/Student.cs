using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMVCApplication.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [Required(ErrorMessage = "Name field is required")]
        public String Name { get; set; }

        [Range(18,55,ErrorMessage = "Age field is required betweeen 18 to 55.")]
        public int Age { get; set; }

        public Standard standard { get; set; }

    }

    public class Standard
    {
        public int StandardId { get; set; }
        public string StandardName { get; set; }
    }
}