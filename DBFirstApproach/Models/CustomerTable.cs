using System;
using System.Collections.Generic;

namespace DBFirstApproach.Models
{
    public partial class CustomerTable
    {
        public int CustId { get; set; }
        public string FirstName { get; set; }
        public string LatName { get; set; }
        public string PhotoUrl { get; set; }
        public string PhoneNo { get; set; }
    }
}
