using DBFirstApproach.Data;
using DBFirstApproach.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBFirstApproach.Controllers
{
    public class CustomerController : Controller
    {
        private DBFirstCurdContext _dBFirstContext;

        public CustomerController(DBFirstCurdContext dBFirstContext)
        {
            _dBFirstContext = dBFirstContext;
        }
        public IActionResult GetAllCustomers()
        {
            List<CustomerTable> customers = _dBFirstContext.CustomerTable.ToList();
            return View(customers);
        }
        [HttpGet]
        public IActionResult AddCustomers()
        {

            
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomers(CustomerTable customerTable)
        {
            _dBFirstContext.CustomerTable.Add(customerTable);
            _dBFirstContext.SaveChanges();

            return View();
        }

        public IActionResult Pagination(int page = 1)
        {
            const int Pagesize = 10;
            if (page < 1)
            {
                page = 1;
            }
            int rescount = _dBFirstContext.CustomerTable.Count();
            var pager = new Pager(rescount, page, Pagesize);
            int resskip = (page - 1) * Pagesize;

            List<CustomerTable> customersTables = _dBFirstContext.CustomerTable.Skip(resskip).Take(pager.PageSize).ToList();

            this.ViewBag.Pager = pager;
            return View(customersTables);
        }
        public IActionResult GetCustomerDetails(int id)
        {
            CustomerTable customers = _dBFirstContext.CustomerTable.Find(id);
            return View(customers);
        }
        [HttpGet]
        public IActionResult EditCustomerDetails(int id)
        {
            CustomerTable customers = _dBFirstContext.CustomerTable.Find(id);
            return View(customers);
        }
        [HttpPost]
        public IActionResult EditCustomerDetails(CustomerTable customersTable)
        {
            _dBFirstContext.Entry(customersTable).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dBFirstContext.SaveChanges();
            return View(customersTable);
        }
        [HttpGet]
        public IActionResult DeleteCustomerDetails(int id)
        {
            CustomerTable customers = _dBFirstContext.CustomerTable.Find(id);
            return View(customers);
        }
        [HttpPost]
        public IActionResult DeleteCustomerDetails(CustomerTable customersTable)
        {
            _dBFirstContext.Remove(customersTable);
            _dBFirstContext.SaveChanges();
            return View(customersTable);
        }
        
    }
}
