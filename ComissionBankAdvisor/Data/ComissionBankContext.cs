using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ComissionBankAdvisor.Models;

namespace ComissionBankAdvisor.Data
{
    public class ComissionBankContext : DbContext
    {
        public ComissionBankContext (DbContextOptions<ComissionBankContext> options) : base(options)
        {
        }

        public DbSet<Pan> Pan { get; set; }
        public DbSet<Advisor> Advisor { get; set; }
        public DbSet<Exchange> Exchange { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Protect> Protect { get; set; }
        public DbSet<Xp> Xp { get; set; }

    }
}
