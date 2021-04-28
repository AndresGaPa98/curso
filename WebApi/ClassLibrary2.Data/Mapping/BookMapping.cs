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
    public class BookMapping: EntityTypeConfiguration<Book>
    {
        public BookMapping() {
            ToTable("Book").HasKey(x => x.Id);
            Property(b => b.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(d => d.Description).IsOptional().HasMaxLength(200);
            Property(t => t.Titulo).IsRequired();
        }
    }
}
