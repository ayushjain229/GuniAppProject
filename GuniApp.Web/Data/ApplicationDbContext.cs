using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

using GuniApp.Web.Models;

namespace GuniApp.Web.Data
{
    public class ApplicationDbContext 
        : IdentityDbContext<MyIdentityUser, MyIdentityRole, Guid>
    {
        public DbSet<Department> Departments { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
