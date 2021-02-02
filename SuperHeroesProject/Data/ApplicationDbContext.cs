using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SuperHeroesProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroesProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<SuperHero> SuperHeroes { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
