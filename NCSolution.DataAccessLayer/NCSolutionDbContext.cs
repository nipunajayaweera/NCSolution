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




    }
}


//Enable-Migrations -ProjectName NCSolution.Migrations -StartupProjectName NCSolution -ContextProjectName NCSolution.DataAccessLayer -ContextTypeName NCSolutionDbContext
//Add-migration     -ProjectName NCSolution.Migrations
//Update-database -ProjectName NCSolution.Migrations -verbose 
