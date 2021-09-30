using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PartyMembership.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PartyMembership.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Party> Parties { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Gender> Genders { get; set; }

    }
}
