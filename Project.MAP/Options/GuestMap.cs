using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class GuestMap:BaseMap<Guest>
    {
        public GuestMap()
        {
            ToTable("Misafirler");
            Property(x => x.FirstName).HasColumnName("Isim");
            Property(x => x.LastName).HasColumnName("SoyIsim");
            Property(x => x.ContactNuber).HasColumnName("İletişim Numarasi");
            Property(x => x.TCKNo).HasColumnName("TCK No");
        }
    }
}
