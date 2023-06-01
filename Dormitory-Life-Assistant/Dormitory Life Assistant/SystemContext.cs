using MySql.Data.EntityFramework;
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;

namespace Dormitory_Life_Assistant
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class SystemContext:DbContext
    {
        public SystemContext() : base("DLADataBase")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SystemContext>());
        }
        public DbSet<SystemMessage> SystemMessages { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Supervisor> Supervisors { get; set; }
    }
}
