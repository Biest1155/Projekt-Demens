using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Demens.Models
{
    public class TipDataContext : DbContext
    {
        public DbSet<Tip> Tips { get; set; }

        public TipDataContext(DbContextOptions<TipDataContext> options)
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
