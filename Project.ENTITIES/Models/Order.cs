using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Order:BaseEntity
    {// müşteri ile bire çok ilişki içindedir
        public string OrderName { get; set; }//sipariş adı
        public decimal OrderPrice { get; set; }// sipariş fiyatı
        public int? GuestID { get; set; }
        // relaational
        public virtual Guest Guest { get; set; }
    }
}
