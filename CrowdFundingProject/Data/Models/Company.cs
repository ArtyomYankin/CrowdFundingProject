using CrowdFundingProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdFundingProject.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal MoneyNeeded { get; set; }
        public decimal MoneyNow { get; set; }
        public string ImageLink { get; set; }
        public int CategoryId { get; set; }
        public string UserId { get; set; }
        public bool IsFavorite { get; set; }
        public virtual ICollection<CompanyNews> CompanyNews { get; set; }
        public virtual User User { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual Category Category { get; set; }
        public ICollection<CompanyComment> CompanyComments { get; set; }
    }
}
