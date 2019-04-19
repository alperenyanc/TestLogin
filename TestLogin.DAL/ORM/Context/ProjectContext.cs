using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLogin.DAL.ORM.Entity;
using TestLogin.DAL.ORM.Map;

namespace TestLogin.DAL.ORM.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "Server=PROJECT-ALPEREN;Database=BLOGDATA;UID=alp;PWD=alp123;";

        }
        public DbSet<AppUser> AppUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AppUserMap());
            base.OnModelCreating(modelBuilder);
        }
        
        
    }
}
