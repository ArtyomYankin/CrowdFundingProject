using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdFundingProject.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal MoneyNeeded { get; set; }
        public string ImageLink { get; set; }
        public ICollection<CompanyCategory> Categories { get; set; }
    }
}
