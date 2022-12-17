using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPage.Models;

namespace WebPage.DataContexts
{
    public class ApplicationContect:DbContext
    {

        public ApplicationContect(DbContextOptions<ApplicationContect> options):base (options)
        { }
        public DbSet<WebFrom> webFroms { get; set; }
        public DbSet<UserRegistration>UserRegistrations{ get; set; }

    }
}
