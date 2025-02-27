using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MpumiStudyGroup.Models
{
	public class myStudyClass1
	{
        //Displaying the student number
        [Display(Name = "Student Number")]
        public int StudentNumber { get; set; }

        [Display(Name = "First Name")]
		public string FirstName { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }
    }
}