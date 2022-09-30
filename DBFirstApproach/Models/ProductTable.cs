using System;
using System.Collections.Generic;

namespace DBFirstApproach.Models
{
    public partial class ProductTable
    {
        public int ProdId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
