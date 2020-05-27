using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebFundDream.Models;

namespace WebFundDream.Controllers
{
    public class CompanyController : Controller
    {
        private CompanyContext db;
        public CompanyController(CompanyContext companyContext) {
            db = companyContext;
        }
        public async Task<IActionResult> ShowCompany()
        {
            return View(await db.Companies.ToListAsync());
        }
        public IActionResult Create()
        {
            return View("Views/Company/CreateCompany.cshtml");
        }
        [HttpPost]
        public async Task<IActionResult> Create(Company company)
        {
            db.Companies.Add(company);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}