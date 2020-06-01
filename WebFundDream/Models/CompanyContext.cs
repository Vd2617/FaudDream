using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFundDream.Models
{
    public class CompanyContext:DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public CompanyContext(DbContextOptions<CompanyContext> options)
            : base(options)
        {
            //Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}
