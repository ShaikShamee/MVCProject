using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails.Models
{
   public interface IOrganization
    {
        List<Organization> GetOrganizations();
    }
}
