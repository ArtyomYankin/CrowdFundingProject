using CrowdFundingProject.Data.Models;
using CrowdFundingProject.Models;
using CrowdFundingProject.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdFundingProject.Controllers
{
    public class CompanyCommentsController : Controller
    {

        private readonly ApplicationDbContext _context;
        public CompanyCommentsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: CompanyComments
        public ActionResult Index()
        {
            return View();
        }

        // GET: CompanyComments/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CompanyComments/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(CompanyCommentViewModel vm)
        {
            var comment = vm.Comment;
            var companyId = vm.CompanyId;
            var rating = vm.Rating;
            CompanyComment artComment = new CompanyComment()
            {
                CompanyId = companyId,
                Comments = comment,
                Rating = rating,
                PublishingDate = DateTime.Now
            };
            _context.CompanyComments.Add(artComment);
            _context.SaveChanges();
            return RedirectToAction("ThisCompany", "Company", new { id = companyId });
        }
        // POST: CompanyComments/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CompanyComments/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CompanyComments/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CompanyComments/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CompanyComments/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
