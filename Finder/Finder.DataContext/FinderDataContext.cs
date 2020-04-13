using Finder.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace Finder.DataContext
{
    public class FinderDataContext : DbContext
    {
        public FinderDataContext(DbContextOptions<FinderDataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Term> Terms { get; set; }
    }
}
