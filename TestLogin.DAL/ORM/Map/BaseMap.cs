using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLogin.DAL.ORM.Entity;

namespace TestLogin.DAL.ORM.Map
{
    public class BaseMap<B>:EntityTypeConfiguration<B> where B:BaseEntity
    {
        public BaseMap()
        {
            Property(x => x.ID).HasColumnName("ID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Status).HasColumnName("Status").IsRequired();
            Property(x => x.UpdateDate).HasColumnName("UpdateDate").IsRequired();
            Property(x => x.DeleteDate).HasColumnName("DeleteDate").IsRequired();
            Property(x => x.AddDate).HasColumnName("AddDate").IsRequired();
        }
    }
}
