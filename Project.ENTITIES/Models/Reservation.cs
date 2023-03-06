using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Reservation:BaseEntity
    {
        // rezervasyon Class'ı
        public DateTime CheckIn { get; set; }// giriş tarihi datetime olarak verdim
        public DateTime CheckOut { get; set; }// çıkış tarihi datetime olarak verdim
   
        //relational
        public virtual List<RoomReservation> Rooms { get; set; }// oda rezervasyon çoka çok ilişkide listi burada
        public virtual List<Guest> Guests { get; set; }// ziyaretçi listem
    }
}
