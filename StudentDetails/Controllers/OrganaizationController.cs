using Microsoft.AspNetCore.Mvc;
using StudentDetails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails.Controllers
{
    public class OrganaizationController : Controller
    {
         public IActionResult IndexData()
        {
            //ViewBag.Message = "Welcome to Organization";
            //ViewData["ITEmployees"] = GetITEmployees();
            //ViewData["NonITEmployees"] = GetNonITEmployees();

            //ViewBag.Message = "Welcome to Organization";
            //OrgnazatioRepo orgnazatioRepo = new OrgnazatioRepo();
            //ViewBag.organizations= orgnazatioRepo.GetOrganizations();

            ITEmployee employee = new ITEmployee()
            {
                EmpId = 1,
                EmpName="seema",
                Email="seema123@gmail.com",
                PhoneNumber="9087654321",
                Age=28
            };
            NonITEmployee nonITEmployee = new NonITEmployee()
            {
                NonEmpId=11,
                NonEmpName="swati",
                Number="5678902345",
                EmailId="swati123@gmail.com",
                Age=29

            };
            Organization organization = new Organization()
            {
                ITEmployees=employee,
                NonITEmployees=nonITEmployee

            };

            return View(organization);
            
        }
    }
}
