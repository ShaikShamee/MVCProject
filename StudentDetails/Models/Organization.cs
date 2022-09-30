using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails.Models
{
    public class Organization
    {

        //public List<ITEmployee> ITEmployees { get; set; }
        //public IEnumerable<NonITEmployee> NonITEmployees { get; set; }
        public ITEmployee ITEmployees { get; set; }
        public NonITEmployee NonITEmployees { get; set; }


    }
}
