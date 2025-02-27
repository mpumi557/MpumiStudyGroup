using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MpumiStudyGroup.Controllers
{
    public class StudyGroupController : Controller
    {
        // GET: StudyGroup
        public ActionResult StudyGroup()
        {
            List<Models.myStudyClass1> people = new List<Models.myStudyClass1>();
            people.Add(new Models.myStudyClass1 { StudentNumber = 24628299, FirstName = "Mpumi", Surname = "Buthelezi", Email = "u24628299@tuks.co.za" });
            people.Add(new Models.myStudyClass1 { StudentNumber = 24628299, FirstName = "Khanyi", Surname = "Mabaso", Email = "u2425628@tuks.co.za" });
            people.Add(new Models.myStudyClass1 { StudentNumber = 24628299, FirstName = "Nombuso", Surname = "Mathebula", Email = "u2459279@tuks.co.za" });
            people.Add(new Models.myStudyClass1 { StudentNumber = 24628299, FirstName = "Aabha", Surname = "Samuels", Email = "u22346271@tuks.co.za" });
            people.Add(new Models.myStudyClass1 { StudentNumber = 24628299, FirstName = "Lesedi", Surname = "Nakedi", Email = "u24623568@tuks.co.za" });

            return View(people);
        }
    }
}