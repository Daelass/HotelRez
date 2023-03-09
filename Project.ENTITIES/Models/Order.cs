using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Order:BaseEntity
    {// oda  ile bire çok ilişki içindedir
        public string OrderName { get; set; }//sipariş adı
        public int? ReservationID { get; set; }

        // relational
        public virtual Reservation Reservation { get; set; }
        
    }
}
