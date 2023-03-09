using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class RoomServiceMap:BaseMap<RoomService>
    {
        public RoomServiceMap()
        {
            ToTable("Oda Servisleri");
            Property(x =>x.Menu).HasColumnName("Menü");
            Property(x =>x.Beverage).HasColumnName("İçecek");
            Property(x=>x.Price).HasColumnName("Fiyat").HasColumnType("money");
        }
    }
}
