using WarriorCombatAcademyTrainer.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Common;

namespace WarriorCombatAcademyTrainer.DAL
{
    public class TrainingContext : DbContext
    {

        public TrainingContext() : base("TrainingContext")
        {
        }

        

        public DbSet<Student> Students { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<SubmissionLog> SubmissionLogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}