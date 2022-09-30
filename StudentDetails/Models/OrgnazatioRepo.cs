using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails.Models
{
    public class OrgnazatioRepo:IOrganization
    {

           public static List<ITEmployee> iTEmployees = new List<ITEmployee>()
            { 
              new ITEmployee { EmpId = 1, EmpName = "Seema", Email = "Seema123@gmail.com", PhoneNumber = "56688900864", Age = 26 },
              new ITEmployee { EmpId = 1, EmpName = "Seema", Email = "Seema123@gmail.com", PhoneNumber = "56688900864", Age = 26 },
              new ITEmployee { EmpId = 1, EmpName = "Seema", Email = "Seema123@gmail.com", PhoneNumber = "56688900864", Age = 26 }
           };



        public static List<NonITEmployee> nonITEmployees = new List<NonITEmployee>()
           {
            new NonITEmployee { NonEmpId = 10, NonEmpName = "anuja", EmailId = "anjua123@gmail.com", Number = "8907654321", Age = 22 },
            new NonITEmployee { NonEmpId = 10, NonEmpName = "anuja", EmailId = "anjua123@gmail.com", Number = "8907654321", Age = 22 },
            new NonITEmployee { NonEmpId = 10, NonEmpName = "anuja", EmailId = "anjua123@gmail.com", Number = "8907654321", Age = 22 }
           };
           
        
       public static List<Organization> organizations = new List<Organization>()
        {
            new Organization{ITEmployees=iTEmployees,NonITEmployees=nonITEmployees },
             new Organization{ITEmployees=iTEmployees,NonITEmployees=nonITEmployees },
              new Organization{ITEmployees=iTEmployees,NonITEmployees=nonITEmployees },
        };
        public List<Organization> GetOrganizations()
        {
            return organizations;
        }

    }
}
