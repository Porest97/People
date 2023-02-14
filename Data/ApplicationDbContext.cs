using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using People.Models.DataModels;

namespace People.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<People.Models.DataModels.Person> Person { get; set; }
        public DbSet<People.Models.DataModels.Company> Companies { get; set; }
    }
}
