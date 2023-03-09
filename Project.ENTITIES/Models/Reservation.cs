using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Reservation:BaseEntity
    {// rezervasyonla misafir bir çok ilişkidedir.
     // rezervasyonla oda ise çoka çok ilişkidedir
        // rezervasyon Class'ı
        public DateTime CheckIn { get; set; }// giriş tarihi datetime olarak verdim
        public DateTime CheckOut { get; set; }// çıkış tarihi datetime olarak verdim
        public int? ReceptionID { get; set; }

        //relational
        public virtual List<RoomReservation> RoomReservations { get; set; }// oda rezervasyon çoka çok ilişkide listi burada
        public virtual Guest Guest { get; set; }
        public virtual List<Customer> Customers { get; set; }// müşteri n rezervasyon yapabilir
        public virtual Reception Reception { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
