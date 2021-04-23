using CrowdFundingProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdFundingProject.Companies
{
    public class CreateCompany
    {
        private ApplicationDbContext _context;
        public CreateCompany (ApplicationDbContext context)
        {
            _context = context;
        }
        public void Do (int id, string Name, string Description)
        {
            _context.Companies.Add(new Company
            {
                Id = id,
                Name = Name,
                LongDescription = Description
            });
        }
    }
}
