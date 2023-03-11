using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class ReceptionMap:BaseMap<Reception>
    {
        public ReceptionMap() 
        {
            ToTable("Resepsiyonlar");
            Property(x => x.UserName).HasColumnName("Kullanıcı Adı");
            Property(x => x.Password).HasColumnName("Şifre");
            Property(x => x.EmployeeFirstName).HasColumnName("Personel İsim");
            Property(x => x.EmployeeLastName).HasColumnName("Personel Soysisim");
            Property(x => x.ReceptionNumber).HasColumnName("Resepsiyon Numarası");
        }
    }
}
