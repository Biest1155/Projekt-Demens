using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Demens.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Tip> Tips { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Stat> Stats { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
            
        }

        public List<Tip> GetPatientTips()
        {
            return Tips.Where(x => x.Type == Tip.TipType.patient).ToList();
        }

        public List<Tip> GetRelativeTips()
        {
            return Tips.Where(x => x.Type == Tip.TipType.relative).ToList();
        }
    }
}
