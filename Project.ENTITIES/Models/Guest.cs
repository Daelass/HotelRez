using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Guest:BaseEntity
    {// ezervasyonu yapan kişiyle odada kalan kişi aynı olmak zorund değil bundan dolayı bu class açılmıştır.
        public string FirstName { get; set; }// adı
        public string LastName { get; set; }// soyadı
        public string  ContactNuber { get; set; }// iletişim numarası
        public string TCKNo { get; set; }// tcknoyu oda da kalan kişi o olduğu için özellik olarak verdim
        public int? RoomID { get; set; }
        // relational
        public virtual List<Order> Orders { get; set; }
        public virtual Room Room { get; set; }
        public virtual List<CompanyCustomerGuest> CompanyCustomerGuests { get; set; }
    }
}
