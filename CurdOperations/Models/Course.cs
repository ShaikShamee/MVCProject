using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurdOperations.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public double Fee { get; set; }
        public string Faculty { get; set; }
    }
}
