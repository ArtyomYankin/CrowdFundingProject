using CrowdFundingProject.Interfaces;
using CrowdFundingProject.Models;
using CrowdFundingProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdFundingProject.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyRepository _allCompanies;
        public CompanyController (ICompanyRepository allCompanies)
        {
            _allCompanies = allCompanies;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ThisCompany(string companyName)
        {
            IEnumerable<Company> companies= null;
            companies = _allCompanies.Companies.Where(i => i.Name.Equals(companyName));
            return View(companies);
        }
    }
}
