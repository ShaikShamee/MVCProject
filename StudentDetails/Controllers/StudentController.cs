using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentDetails.Models;

namespace StudentDetails.Controllers
{
    public class StudentController : Controller
    {
        //public List<Student> GetStudentDetails()
        //{
        //    List<Student> studentDetails = new List<Student>()
        //    {
        //        new Student(){StudentID=10,Name="shaik seema",Gender="FeMale",Number="7890654321"},
        //        new Student(){StudentID=11,Name="shaik Aliya",Gender="FeMale",Number="8906543217"},
        //        new Student(){StudentID=12,Name="shaik Anjum",Gender="FeMale",Number="9065432178"},
        //        new Student(){StudentID=13,Name="shaik rehan",Gender="Male",Number="9065432156"},
        //    };
        //    return studentDetails;
        //}

        public IActionResult GetOrganizationData()
        {
            //ViewBag.Message = "Welcome to Organization";
            //OrgnazatioRepo orgnazatioRepo = new OrgnazatioRepo();
            //List<Organization> organization = orgnazatioRepo.GetOrganizations();

            //return View(organization);
            return View();
        }
    }
}
