using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public  class Reception:BaseEntity
    {//  resepsiyon ile profili bire bir ilşkidedir.
        // resepsiyon ile müşteri(rezervasyon yaptıran kişi) bire çok ilişkidedir.
        

        public string UserName { get; set; }// kullanıcı adı
        public string Password { get; set; }// şifresi

        // relational
        public virtual ReceptionProfile ReceptionProfile { get; set; }
        public virtual List<Customer> Customers { get; set; }
        public virtual List<Reservation> Reservations { get; set; }

    }
}
