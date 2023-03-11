using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class HouseKeeperMap:BaseMap<HouseKeeper>
    {
        public HouseKeeperMap() 
        {
            ToTable("Oda Temizlik Servisleri");
            Property(x => x.FirstName).HasColumnName("İsim");
            Property(x => x.LastName).HasColumnName("Soyisim");
            Property(x => x.ContactNumber).HasColumnName("İletişim Numarası");
        }
    }
}
