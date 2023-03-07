using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class CompanyCustomerGuest:BaseEntity
    {// rezervasyonu yapan kişiyle kalan kişinin ilişki durumu bu class içerisinde belirtilmiştir.
        public int CompanyCustomerID { get; set; }
        public int GuestID { get; set; }

        //relational
        public virtual CompanyCustomer CompanyCustomer { get; set; }
        public virtual Guest Guest { get; set; }
    }
}
