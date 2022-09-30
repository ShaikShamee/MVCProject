using CurdOperations.Data;
using CurdOperations.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurdOperations.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private readonly CourseDbContext _context;
        public CourseController(CourseDbContext context)
        {
            _context = context;
        }
        public IActionResult GetCourseLists()
        {
            var course = _context.Courses.ToList();
            return View(course);
        }
        
        public ActionResult AddCourse()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCourse(Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Courses.Add(course);
                _context.SaveChanges();
            }
            // return View(course);
            return RedirectToAction("GetCourseLists");
        }

        public ActionResult GetCourseById(int id)
        {
            var course = _context.Courses.Find(id);
            return View(course);

        }
       
        public ActionResult DeleteCourse(int Id)
        {
            var course = _context.Courses.Find(Id);
            return View(course);
        }
        [HttpPost]
        public ActionResult DeleteCourse(Course course)
        {
             _context.Courses.Remove(course);
            _context.SaveChanges();
            // return View(course);
            return RedirectToAction("GetCourseLists");
        }
        public ActionResult UpdateCourse(int id)
        {
            var course = _context.Courses.Find(id);
            return View(course);
        }
        [HttpPost]
        public ActionResult UpdateCourse(Course course)
        {
            _context.Entry(course).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            // return View(course);
            return RedirectToAction("GetCourseLists");
        }
    }
}
