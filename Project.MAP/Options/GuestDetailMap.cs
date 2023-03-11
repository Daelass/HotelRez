using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class GuestDetailMap:BaseMap<GuestDetail>
    {
        public GuestDetailMap() 
        {
            ToTable("Misafir Detayları");

            //Guest ve Rezervasyon arasında ki çoka çok ilişkinin ikinci fazı

            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.GuestID,
                x.ReservationID
            });
        }
    }
}
