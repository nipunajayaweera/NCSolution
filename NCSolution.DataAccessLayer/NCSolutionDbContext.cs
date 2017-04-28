using NCSolution.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSolution.DataAccessLayer
{
    public class NCSolutionDbContext : DbContext
    {

        public NCSolutionDbContext() : base("NCSolutionDbContext")
        {

        }

        public DbSet<LoginUser> LoginUsers { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<UserExamAttempt> UserExamAttempts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            

        }
    }
}


//Enable-Migrations -ProjectName NCSolution.Migrations -StartupProjectName NCSolution -ContextProjectName NCSolution.DataAccessLayer -ContextTypeName NCSolutionDbContext
//Add-migration     -ProjectName NCSolution.Migrations
//Update-database -ProjectName NCSolution.Migrations -verbose 
