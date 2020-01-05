using MySql.Data.Entity;
using SMS.Service.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Service.DatabaseContext
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class StudentContext : DbContext, IStudentContext
    {
        public StudentContext(DbConnection connection) : base(connection, true)
        {

        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Setup(modelBuilder.Entity<Student>());
        }

        private void Setup(EntityTypeConfiguration<Student> entity)
        {
            entity.ToTable("Student");
            entity.HasKey(x => x.Id);
        }
    }
}
