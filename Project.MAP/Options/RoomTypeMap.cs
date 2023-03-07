using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class RoomTypeMap : BaseMap<RoomType>
    {
        public RoomTypeMap()
        {
            ToTable("Oda Tipleri");
            Property(x=> x.TypeName).HasColumnName("Oda Tipi");
            Property(x => x.RoomPrice).HasColumnName("Oda Fiyati");
        }
    }
}
