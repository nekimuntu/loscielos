using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class loscielosDbContext : DbContext
    {
        public loscielosDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cabin> Cabins { get; set; }
    }
}