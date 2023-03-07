using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class ReservationMap:BaseMap<Reservation>
    {
        public ReservationMap()
        {
            ToTable("Rezarvasyonlar");
            Property(x=>x.CheckIn).HasColumnName("Giriş Tarihi");
            Property(x=>x.CheckOut).HasColumnName("Çıkış Tarihi");
        }
    }
}
