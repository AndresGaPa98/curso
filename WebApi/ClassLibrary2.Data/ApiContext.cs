using ClassLibrary2.Data.Mapping;
using ClassLibrary2.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext() : base("ProjectApi")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ApiContext>());
        }
        public DbSet<Book> books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new BookMapping());
            modelBuilder.Configurations.Add(new AutorMapping());
        }
    }
}
