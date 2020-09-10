using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingWeb.Models;

namespace AccountingWeb.AppDbContext
{
    public class AccountingDbContext:DbContext
    {
        public AccountingDbContext(DbContextOptions<AccountingDbContext> options):
            base(options)
        {

        }
        public DbSet<firm> firm { get; set; }
        public DbSet<UserRights> UserRights { get; set; }
        public DbSet<ucs_users> ucs_users { get; set; }
        public DbSet<transmain> transmain { get; set; }
        public DbSet<VBook> VBook { get; set; }
    }
}
