using CrowdFundingProject.Data.Models;
using CrowdFundingProject.Interfaces;
using CrowdFundingProject.Models;
using CrowdFundingProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdFundingProject.Controllers
{
    public class CompanyController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly ICompanyRepository _allCompanies;
        public CompanyController (ICompanyRepository allCompanies, ApplicationDbContext context)
        {
            _allCompanies = allCompanies;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ThisCompany(int companyId)
        {
            //Company company = _context.Companies.Find(companyId);
            
            Company companies = _allCompanies.Companies.Where(i => i.CompanyId.Equals(companyId)).FirstOrDefault();

            CompanyCommentViewModel vm = new CompanyCommentViewModel();
            vm.CompanyId = companyId;
            vm.Title = companies.Name;
            var Comments = _context.CompanyComments.Where(p => p.CompanyId.Equals(companyId)).ToList();
            var Ratings = _context.CompanyComments.Where(p => p.CompanyId.Equals(companyId)).ToList();
            companies.CompanyComments = Comments;
            if (Ratings.Count() > 0)
            {

                var RatingSum = Ratings.Sum(p => p.Rating);
                ViewBag.RatingSum = RatingSum;
                var RatingCount = Ratings.Count();
                ViewBag.RatingCount = RatingCount;
            }
            else
            {
                ViewBag.RatingSum = 0;
                ViewBag.RatingCount = 0;
            }
            return View(companies);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            Company company = _allCompanies.Companies.FirstOrDefault(p => p.CompanyId == id);
            if (company != null)
            {
                _context.Companies.Remove(company);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Account");
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Company company =  await _context.Companies.FirstOrDefaultAsync(p => p.CompanyId == id);
                if (company != null)
                    return View(company);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Company company)
        {
            _context.Update(company).Property(p=>p.CompanyId).IsModified = false;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Account");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CompanyNews companyNews, int companyId)
        {
            companyNews.CompanyId = companyId;
            companyNews.DatePost = DateTime.Now;
            _context.CompanyNews.Add(companyNews);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
