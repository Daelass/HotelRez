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
            ToTable("Rezervasyonlar");
            Property(x => x.RezervationDate).HasColumnName("Rezervasyon Tarihi");
            Property(x => x.CheckIn).HasColumnName("Giriş");
            Property(x => x.CheckOut).HasColumnName("Çıkış");
            Property(x => x.TotalPrice).HasColumnName("Toplam Tutar");
        }
    }
}
