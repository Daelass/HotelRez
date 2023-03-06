using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Guest:BaseEntity
    {// ziyaretçi class'ı
        public string FirstName  { get; set; } // adı
        public string LastName { get; set; } // soyadı
        public string ContactNumber { get; set; } // iletişim numarası
        public int? ReceptionistID { get; set; }
        public int? ReservationID { get; set; }
        // relational 
        public virtual Receptionist Receptionist { get; set; }// bire çok olduğu için burada 
        public virtual Reservation Reservation { get; set; }// bire çok ilişkide olduğu için
    }
}
