using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Project.ENTITIES.Models;

namespace Project.MAP.Options
{
    public class BaseMap<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseMap()
        {
            Property(x => x.CreatedTime).HasColumnName("Yaratılma Tarihi");
            Property(x => x.ModifiedTime).HasColumnName("Geliştirme Tarihi");
            Property(x => x.DeletedTimee).HasColumnName("Silinme Tarihi");
            Property(x => x.Status).HasColumnName("Veri Durumu");
        }
    }
}
