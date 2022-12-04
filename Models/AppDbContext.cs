using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Journalist.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Journalist.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Entry> Entries { get; set; }   
        public DbSet<User> Users { get; set; }

        public DbSet<Mark> Marks { get; set; }
    }
}