using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class ReceptionMap :BaseMap<Reception>
    {
        public ReceptionMap()
        {
            ToTable("Recepsionlar");
            Property(x =>x.UserName).HasColumnName("Kullanıcı Adı");
            Property(x =>x.Password).HasColumnName("Şifre");
            HasOptional(x => x.ReceptionProfile).WithRequired(x => x.Reception);
        }
    }
}
