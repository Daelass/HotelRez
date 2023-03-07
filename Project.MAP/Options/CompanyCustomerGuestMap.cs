using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class CompanyCustomerGuestMap:BaseMap<CompanyCustomerGuest>
    {
        public CompanyCustomerGuestMap()
        {
            ToTable("Müşteri Misafirleri");
            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.CompanyCustomerID,
                x.GuestID
            });
        }
    }
}
