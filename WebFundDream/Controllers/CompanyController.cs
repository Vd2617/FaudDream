using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using WebFundDream.Models;

namespace WebFundDream.Controllers
{
    public class CompanyController : Controller
    {
        private CompanyContext db;
        IWebHostEnvironment _appEnvironment;
        public CompanyController(CompanyContext companyContext, IWebHostEnvironment appEnvironment)
        {
            db = companyContext;
            _appEnvironment = appEnvironment;

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
        [HttpPost]
        public async Task<IActionResult> Upload(IList<IFormFile> file)
        {
            Random rnd = new Random();
            int value = rnd.Next();
            var filename =  value.ToString() + ".jpg";
            foreach (var item in file)
            {
                if (item.Length > 0)
                {
                    var filePath = _appEnvironment.WebRootPath + "\\uploads\\" +  filename;
                  
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await item.CopyToAsync(fileStream);
                    }
                }
            }
            return StatusCode(200);
        }
    }
}