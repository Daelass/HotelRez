using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class RoomDetailMap:BaseMap<RoomDetail>
    {
        public RoomDetailMap()
        {
            ToTable("Oda Detayları");

            // Room ve Reservation Class'larının arasında ki çok'a çok ilişkinin ikinci fazı

            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.RoomID,
                x.ReservationID
            });
        }
    }
}
