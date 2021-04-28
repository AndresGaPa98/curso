using ClassLibrary2.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Data.Mapping
{
    public class AutorMapping: EntityTypeConfiguration<Autor>
    {
        public AutorMapping()
        {
            ToTable("Autor").HasKey(x => x.Id);
            Property(b => b.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a => a.LastName).IsRequired();
            Property(a => a.FirstName).IsRequired();
        }
    }
}
