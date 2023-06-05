using Dormitory_Life_Assistant.EntityClass;
using MySql.Data.EntityFramework;
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;

namespace Dormitory_Life_Assistant
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class SystemContext : DbContext
    {
        public SystemContext() : base("DLADataBase")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SystemContext>());
        }
        public DbSet<SystemMessage> SystemMessages { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<ClockIn> ClockIns { get; set; }
        public DbSet<Repair> Repairs { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Supervisor> Supervisors { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Dorm> Dorms { get; set; }
        public DbSet<SaveImage> SaveImages { get; set; }

        public DbSet<Complaint> Complaints { get; set; }


        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dorm>()
                .HasKey(d => new { d.ID });

            modelBuilder.Entity<SystemMessage>()
                .HasKey(d => new { d.SystemMessageId });

            base.OnModelCreating(modelBuilder);
        }*/

        public DbSet<ExchangeMessage> ExchangeMessages { get; set; }
        public DbSet<DormMessage> DormMessages { get; set; }
    }
}
