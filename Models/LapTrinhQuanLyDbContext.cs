using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LTQL28.Models
{
    public class LapTrinhQuanLyDbContext : DbContext
    {
        public LapTrinhQuanLyDbContext(): base("name=LTQLDbContext")
        {
        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Employee> Employees{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
             modelBuilder.Entity<Student>()
            .Property(e => e.StudentName)
            .IsUnicode(false);

        }
    }
}
       
