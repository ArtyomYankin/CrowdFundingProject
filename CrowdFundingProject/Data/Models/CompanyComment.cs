using CrowdFundingProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdFundingProject.Data.Models
{
    public class CompanyComment
    {
        public int Id { get; set; }
        public string Comments { get; set; }
        public DateTime PublishingDate { get; set; }
        public int CompanyId { get; set; }
        public Company Companies { get; set; }
        public int Rating { get; set; }
    }
}
