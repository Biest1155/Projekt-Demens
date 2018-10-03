using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Projekt_Demens.Models
{
    public class NewsDataContext:DbContext
    {
        public DbSet<News> News { get; set; }

        public NewsDataContext(DbContextOptions<NewsDataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
