using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class CompanyCustomer:BaseEntity
    {// bu class şirket ve kişinin rezervasyon yapabilmesi için açılmıştır. böylelikle rezervasyon ve mafiri ayırmış olduk.
        public string FirstName  { get; set; } // adı
        public string LastName { get; set; } // soyadı
        public string ContactNumber { get; set; } // iletişim numarası
        public int? EmployeeID { get; set; }
        public int? ReservationID { get; set; }
      
        // relational 
        public virtual Employee Employee { get; set; }// employee ile bire çok ilişki vardır
        public virtual Reservation Reservation { get; set; }// bire çok ilişkide olduğu için
        public virtual List<CompanyCustomerGuest> CompanyCustomerGuests { get; set; }

    }
}
