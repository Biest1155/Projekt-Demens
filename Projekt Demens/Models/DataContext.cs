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
        public DbSet<ChatMessage> Messages { get; set; }

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

        public List<ChatMessage> GetMessagesByTherapist(long user, long patient)
        {
            return Messages.Where(x => x.TerapeutId == user && x.PatientId == patient).OrderBy(x=>x.Id).ToList();
        }
    }
}
