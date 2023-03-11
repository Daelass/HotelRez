using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class RoomMap:BaseMap<Room>
    {
        public RoomMap() 
        {
            ToTable("Odalar");
            Property(x => x.RoomNo).HasColumnName("Oda Numarası");
            Property(x => x.PhoneNumber).HasColumnName("Telefon Numarası");
            Property(x => x.IsOn).HasColumnName("Kullanım Durumu");
        }
    }
}
